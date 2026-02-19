using CSLLMCapstone.Data;
using CSLLMCapstone.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSLLMCapstone.Services
{
    // FlashcardData class holds generated keyword, description as string
    public class FlashcardData
    {
        public string keyword { get; set; } = "";
        public string description { get; set; } = "";
    }

    // QuizData class holds generated question as string, options as list of strings, and answer as string  
    public class QuizData
    {
        public string questionID { get; set; } = ""; // To store "question 1"

        [JsonPropertyName("question text")] // this forces it to map the key with the space
        public string questionText { get; set; } = "";
        public List<string> options { get; set; } = new List<string>();
        public string answer { get; set; } = "";
        public string answer_desc { get; set; } = ""; // optional field for future use, not currently used in the prompt } 
    }

    // TutorConversationData class holds the role of the speaker (tutor or student) and the content of the message as string
    public class TutorConversationData
    {
        public string role { get; set; } = "";
        public string content { get; set; } = "";
    }

    public class LLMService
    {

        // public methods --------------------------------------------------------------------------------------------------------------------------------

        // returning generated flashcard data in validated JSON formatted plaintext 
        // would used for generating data for database
        public async Task<string> GenerateFlashCardDataValidatedJSONAsync(LLM llm, string courseName, string courseDesc, List<string>courseTopics, string? history)
        {
            string JSON = ""; // buffer 

            if (history != null)
            {
                JSON = await GenerateFlashCardDataWithHistoryAsync(llm, courseName, courseDesc, courseTopics, history);
            }
            else
            {
                JSON = await GenerateFlashCardDataAsync(llm, courseName, courseDesc, courseTopics);
            }

            return validateJSON(JSON);
        }

        // returning generated quiz data in validated JSON formatted plaintext
        // would used for generating data for database
        public async Task<string> GenerateQuizDataValidatedJSONAsync(LLM llm, string courseName, string courseDesc, List<string>courseTopics, string? history)
        {
            string JSON = ""; // buffer

            if (history != null)
            {
                JSON = await GenerateQuizDataWithHistoryAsync(llm, courseName, courseDesc, courseTopics, history);  
            }
            else
            {
                JSON = await GenerateQuizDataAsync(llm, courseName, courseDesc, courseTopics);  
            }

            return validateJSON(JSON);

        }


        // returning generated flash card data in list type
        public List<Tuple<string, string>>  GenerateFlashCardDataList(string JSONValidatedData)
        {
            List<Tuple<string, string>> flashcardData = new List<Tuple<string, string>>();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // JSON serializer ignores case
            };

            var rawDict = JsonSerializer.Deserialize<Dictionary<string, FlashcardData>>(JSONValidatedData, options);

            if(rawDict != null)
            {
                foreach(var item in rawDict)
                {
                    flashcardData.Add(new Tuple<string, string>(item.Value.keyword, item.Value.description));
                }
            }

            return flashcardData;
        }


        /*

        // returning generated flash card data in list type
        public async Task<List<Tuple<string, string>>> GenerateFlashCardDataListAsync(LLM llm, string courseName, string courseDesc, List<string>courseTopics, string? history)
        {
            string validatedJSONRawData = "";
            List<Tuple<string, string>> flashcardData = new List<Tuple<string, string>>();

            if(history != null)
            {
                validatedJSONRawData = validateJSON(await GenerateFlashCardDataWithHistoryAsync(llm, courseName, courseDesc, courseTopics, history));
            }
            else
            {
                validatedJSONRawData = validateJSON(await GenerateFlashCardDataAsync(llm, courseName, courseDesc, courseTopics));
            }

            // set the json serializer rule
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // JSON serializer ignores case
            };

            // generate raw dictionary from the validated JSON data
            var rawDict = JsonSerializer.Deserialize<Dictionary<string, FlashcardData>>(validatedJSONRawData, options);

            if(rawDict != null)
            {
                foreach(var item in rawDict)
                {
                    flashcardData.Add(new Tuple<string, string>(item.Value.keyword, item.Value.description));
                }
            }

            return flashcardData;
        }
        */
        // returning generated quiz data in list type
        public List<List<string>> GenerateQuizDataList(string JSONValidatedData)
        {
            List<List<string>> quizData = new List<List<string>>();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            // dserialize into a Dictionary to capture the "Question 1" keys
            var rawDict = JsonSerializer.Deserialize<Dictionary<string, QuizData>>(JSONValidatedData, options);

            if (rawDict != null)
            {
                foreach (var item in rawDict)
                {
                    var row = new List<string>();

                    // add the "Question ID" (e.g., "question 1") first so it's not ignored
                    row.Add(item.Key);

                    // add the actual question text
                    row.Add(item.Value.questionText);

                    // add all the options
                    foreach (var option in item.Value.options)
                    {
                        row.Add(option);
                    }

                    // add the correct answer at the end
                    row.Add(item.Value.answer);

                    // add the answer description at the end 
                    row.Add(item.Value.answer_desc);

                    // add this completed "row" to your master list
                    quizData.Add(row);
                }
            }

            return quizData;
        }

        // This method checks the tutor response and strips any markdown formatting before displaying it in the UI
        private string StripMarkdown(string text)
        {
            if (string.IsNullOrEmpty(text)) return text;

            // Remove common Markdown symbols using simple string replacements
            return text
                .Replace("**", "")   // Bold
                .Replace("__", "")   // Bold/Italic
                .Replace("#", "")    // Headers
                .Replace("`", "")    // Code blocks
                .Replace("* ", "• ") // Convert markdown bullets to standard bullet points
                .Trim();
        }

        // returning generated tutor response in TutorConversationData type
        public async Task<TutorConversationData> GenerateTutorResponse(LLM llm, string userInput, List<TutorConversationData> history)
        {
            // 1. Create a string of the history so the LLM has context
            // We use a StringBuilder or Join for better performance
            string conversationHistoryString = string.Join(" ", history.Select(h => $"{h.role}: {h.content}"));

            // 2. Add explicit "Plain Text" instructions to the prompt
            string prompt = $"You are a helpful Computer Science Tutor. " +
                            $"IMPORTANT: Provide your answer in PLAIN TEXT only. Do not use Markdown, " +
                            $"do not use asterisks for bold, do not use hashtags for headers, " +
                            $"and do not use backticks for code. Use standard indentation and capitalization. " +
                            $"Based on the following history, answer the student's question. " +
                            $"History: {conversationHistoryString} " +
                            $"Student Question: {userInput}";

            // 3. Get the response from the LLM
            string tutorResponse = await llm.AskAsync(prompt);
            string cleanedResponse = StripMarkdown(tutorResponse); // Remove any markdown formatting

            // 4. Return the new message object
            return new TutorConversationData
            {
                role = "tutor",
                content = cleanedResponse
            };
        }

        /*
        public List<List<string>> GenerateQuizDataList(string JSONValidatedData)
        {
            
            List<List<string>> quizData = new List<List<string>>();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // JSON serializer ignores case
            };


            var rawDict = JsonSerializer.Deserialize<Dictionary<string, QuizData>>(JSONValidatedData, options);
            
            if(rawDict != null)
            {

               
       
                foreach(var entity in rawDict.Values) // takes values only
                {
                    var row = new List<string>(); // each row will hold ["Question", "option #", "answer"]
                    Console.WriteLine(entity.questionText);
                    row.Add(entity.questionText);
                    foreach(var cand in entity.options) // add each candidates into quiz content list
                    {
                        row.Add(cand);
                    }
                    row.Add(entity.answer); // add the answer into quiz content list
                    quizData.Add(row); // add completed question into the quiz container list
                }
                
            }
            

            // 1. Deserialize into a Dictionary because of the "question X" keys
            var rawData = JsonSerializer.Deserialize<Dictionary<string, QuizData>>(JSONValidatedData);

            // 2. Convert that Dictionary into a List of your QuizData objects
            //List<QuizData> quizList = rawData.Values.ToList();

            List<QuizData> quizList = rawData.Select(kvp => {
                kvp.Value.questionID = kvp.Key;
                return kvp.Value;
            }).ToList();

            return quizData;
        }
        */

        /*
        // returning generated quiz data in list type
        public async Task<List<List<string>>> GenerateQuizDataListAsync(LLM llm, string courseName, string courseDesc, List<string>courseTopics, string? history)
        {

            string validatedJSONRawData = ""; 
            List<List<string>> quizData = new List<List<string>>();

            if(history != null) // if the user has query history as JSON formatted plaintext string
            {
                validatedJSONRawData = validateJSON(await GenerateQuizDataWithHistoryAsync(llm, courseName, courseDesc, courseTopics, history));
            }
            else // if this is first llm query
            {
                validatedJSONRawData = validateJSON(await GenerateQuizDataAsync(llm, courseName, courseDesc, courseTopics));
            }

            var options = new JsonSerializerOptions // preparing JSON serializer
            {
                PropertyNameCaseInsensitive = true // JSON serializer doesn't care case
            };

            var rawDict = JsonSerializer.Deserialize<Dictionary<string, QuizData>>(validatedJSONRawData, options);

            if(rawDict != null)
            {
                foreach(var entity in rawDict.Values) // takes values only
                {
                    var row = new List<string>(); // each row will hold ["Question", "option #", "answer"]
                    row.Add(entity.questionText);

                    foreach(var cand in entity.options) // add each candidates into quiz content list
                    {
                        row.Add(cand);
                    }

                    row.Add(entity.answer); // add the answer into quiz content list

                    quizData.Add(row); // add completed question into the quiz container list
                }
            }


            return quizData;
        }

        */

        // private methods -------------------------------------------------------------------------------------------------------------------------------

        // GenerateFlashCardDataAsync() generates flashcard data with given course topics
        private async Task<string> GenerateFlashCardDataAsync(LLM llm, string courseName, string courseDesc, List<string> courseTopics)
        {
            // build a string for the llm query
            string topicString = string.Join(", ", courseTopics);

            // generate raw plaintext output from the model
            string JSONRawOutput = await llm.AskAsync($"Generate Flashcards as instructed for the Course name: {courseName}, Course Topics: {topicString}, and Course Description: {courseDesc}.");

            return JSONRawOutput;
        }

        // GenerateFlashCardDataWithHistoryAsync() generates flashcard data with given course topics. It takes previously generated materials to prevent duplicate
        private async Task<string> GenerateFlashCardDataWithHistoryAsync(LLM llm, string courseName, string courseDesc, List<string> courseTopics, string history)
        {
            // build a string for the llm query
            string topicString = string.Join(", ", courseTopics);

            // generate raw plaintext output from the model with history
            string JSONRawOutput = await llm.AskAsync($"Generate Flashcards as instructed for the Course name: {courseName}, Course Topics: {topicString}, and Course Description: {courseDesc}. Your previously generated flashcard data in JSON format: {history}, and do not generate exactly same as provided JSON format.");

            return JSONRawOutput;
        }

        // GenerateQuizDataAsync() generates quiz data with given course topics
        private async Task<string> GenerateQuizDataAsync(LLM llm, string courseName, string courseDesc, List<string> courseTopics)
        {
            // build a string for the llm query
            string topicString = string.Join(", ", courseTopics);

            // generate raw plaintext output from the model
            string JSONRawOutput = await llm.AskAsync($"Generate Quizes as initial prompt for the Course name: {courseName}, Course Topics: {topicString}, and Course Description: {courseDesc}.");

            return JSONRawOutput;
        }

        // GenerateQuizDataWithHistoryAsync() generates quiz data with given course topics. It takes previously generated materials to prevent duplicate
        private async Task<string> GenerateQuizDataWithHistoryAsync(LLM llm, string courseName, string courseDesc, List<string> courseTopics, string history)
        {
            // build a string for the llm query
            string topicString = string.Join(", ", courseTopics);

            // generate raw plaintext output from the model
            string JSONRawOutput = await llm.AskAsync($"Generate Quizes as initial prompt for the Course name: {courseName}, Course Topics: {topicString}, and Course Description: {courseDesc}. Your previously generated quiz data in JSON format: {history}, and do not generate exactly same as provided JSON format.");

            return JSONRawOutput;
        }

        // validateJSON function takes generated JSON formatted plaintext and remove unnecessary noizes. 
        private string validateJSON(string JSONRawOutput) 
        {
            string JSON = ""; // buffer
            bool isOpened = false; //write flag
            Stack<char> brackets = new Stack<char>(); // stack to count opening brackets

            for(int i = 0; i < JSONRawOutput.Length; i++)
            {
                if (JSONRawOutput[i] == '{') // if opening bracket
                {
                    brackets.Push(JSONRawOutput[i]); // push into the stack

                    if(!isOpened) // if it was first opening bracket
                    {
                        isOpened = true; // set the write flag
                    }

                    JSON += JSONRawOutput[i];
                }
                else // otherwise, 
                {
                    if (JSONRawOutput[i] == '}') // if it is closing bracket
                    {

                        char lastBracket = brackets.Pop(); // pop the last opening bracket from the stack

                        if(brackets.Count == 0) // check if it is the last closing bracket
                        {
                            JSON += JSONRawOutput[i];  // store it into the buffer
                            break; // escape the loop
                        }
                        else // otherwise,
                        {
                            JSON += JSONRawOutput[i];
                        }

                    }
                    else // otherwise,
                    {
                        if(isOpened) // check if the writing flag is set
                        {
                            JSON += JSONRawOutput[i]; // if so, store into the buffer
                        }
                    }
                }

            }

            return JSON;
        }

    }
}

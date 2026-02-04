using CSLLMCapstone.Models;
using CSLLMCapstone.Data;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System.Data;
using System.Text.Json;

namespace CSLLMCapstone.Services
{

    // data interface


    /*
     
    flashcard JSON:

    { "question" : ["keyword" : "<keyword>", "description" : "<description>"]}

    quiz JSON:

    {"quiz #" : {"options" : [ 4 options here ], "answer" : "<answer from candidates>"}}

     */
    public class FlashCardData
    {
        public string keyword { get; set; } = "";
        public string description { get; set; } = "";
    }

    public class QuizData
    {
        public string questionText { get; set; } = "";
        public List<string> options { get; set; } = new List<string>();
        public string answer { get; set; } = "";
    }

    public class LLMService
    {

        // public methods --------------------------------------------------------------------------------------------------------------------------------

        // returning generated flashcard data in validated JSON formatted plaintext 
        // would used for generating data for database
        public async Task<string> GenerateFlashCardDataValidatedJSONAsync(LLM llm, string courseName, List<string>courseTopics, string? history)
        {
            if (history != null)
            {
                return validateJSON(await GenerateFlashCardDataWithHistoryAsync(llm, courseName, courseTopics, history));
            }
            else
            {
                return validateJSON(await GenerateFlashCardDataAsync(llm, courseName, courseTopics));
            }
        }

        // returning generated quiz data in validated JSON formatted plaintext
        // would used for generating data for database
        public async Task<string> GenerateQuizDataValidatedJSONAsync(LLM llm, string courseName, List<string>courseTopics, string? history)
        {
            if (history != null)
            {
                return validateJSON(await GenerateQuizDataWithHistoryAsync(llm, courseName, courseTopics, history));
            }
            else
            {
                return validateJSON(await GenerateQuizDataAsync(llm, courseName, courseTopics));
            }
        
        }

        // returning generated flash card data in list type
        public async Task<List<Tuple<string, string>>> GenerateFlashCardDataListAsync(LLM llm, string courseName, List<string>courseTopics, string? history)
        {
            string validatedJSONRawData = "";
            List<Tuple<string, string>> flashcardData = new List<Tuple<string, string>>();

            if(history != null)
            {
                validatedJSONRawData = validateJSON(await GenerateFlashCardDataWithHistoryAsync(llm, courseName, courseTopics, history));
            }
            else
            {
                validatedJSONRawData = validateJSON(await GenerateFlashCardDataAsync(llm, courseName, courseTopics));
            }

            // parse logic here


            // set the json serializer rule
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            // generate raw dictionary from the validated JSON data
            var rawDict = JsonSerializer.Deserialize<Dictionary<string, FlashCardData>>(validatedJSONRawData, options);

            if(rawDict != null)
            {
                foreach(var item in rawDict)
                {
                    flashcardData.Add(new Tuple<string, string>(item.Value.keyword, item.Value.description));
                }
            }

            return flashcardData;
        }

        // returning generated quiz data in list type
        public async Task<List<List<string>>> GenerateQuizDataListAsync(LLM llm, string courseName, List<string>courseTopics, string? history)
        {

            string validatedJSONRawData = "";
            List<List<string>> quizData = new List<List<string>>();

            if(history != null)
            {
                validatedJSONRawData = validateJSON(await GenerateQuizDataWithHistoryAsync(llm, courseName, courseTopics, history));
            }
            else
            {
                validatedJSONRawData = validateJSON(await GenerateQuizDataAsync(llm, courseName, courseTopics));
            }

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };


            // funny thing, since we are passing QuizData interface, JsonSerializer will automatically parse as QuizData.
            var rawDict = JsonSerializer.Deserialize<Dictionary<string, QuizData>>(validatedJSONRawData, options);

            if(rawDict != null)
            {
                foreach(var entity in rawDict.Values)
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


        // private methods -------------------------------------------------------------------------------------------------------------------------------
        private async Task<string> GenerateFlashCardDataAsync(LLM llm, string courseName, List<string> courseTopics)
        {
            // build a string for the llm query
            string topicString = string.Join(", ", courseTopics);

            // generate raw plaintext output from the model
            string JSONRawOutput = await llm.AskAsync($"Generate Flashcards as instructed for the Course name: {courseName}, Course Topics: {topicString}.");

            return JSONRawOutput;
        }

        private async Task<string> GenerateFlashCardDataWithHistoryAsync(LLM llm, string courseName, List<string> courseTopics, string history)
        {
            // build a string for the llm query
            string topicString = string.Join(", ", courseTopics);

            // generate raw plaintext output from the model with history
            string JSONRawOutput = await llm.AskAsync($"Generate Flashcards as instructed for the Course name: {courseName}, Course Topics: {topicString}. Your previously generated flashcard data in JSON format: {history}, and do not generate exactly same as provided JSON format.");

            return JSONRawOutput;
        }

        private async Task<string> GenerateQuizDataAsync(LLM llm, string courseName, List<string> courseTopics)
        {
            // build a string for the llm query
            string topicString = string.Join(", ", courseTopics);

            // generate raw plaintext output from the model
            string JSONRawOutput = await llm.AskAsync($"Generate Quizes as initial prompt for the Course name: {courseName}, Course Topics: {topicString}");

            return JSONRawOutput;
        }

        private async Task<string> GenerateQuizDataWithHistoryAsync(LLM llm, string courseName, List<string> courseTopics, string history)
        {

            // build a string for the llm query
            string topicString = string.Join(", ", courseTopics);

            // generate raw plaintext output from the model
            string JSONRawOutput = await llm.AskAsync($"Generate Quizes as initial prompt for the Course name: {courseName}, Course Topics: {topicString}. Your previously generated quiz data in JSON format: {history}, and do not generate exactly same as provided JSON format.");

            return JSONRawOutput;
        }



        private string validateJSON(string JSONRawOutput) // takes only JSON format string. Disregards any characters that is not part of the JSON
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

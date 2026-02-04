using System.Threading.Tasks;
using System.Collections.Generic;
using Google.GenAI;
using Google.GenAI.Types;
using CSLLMCapstone.Services;


namespace CSLLMCapstone.Models
{
    public class LLM
    {

        private Client client;
        private string modelName = "gemini-3-flash-preview";
        private string fallbackPrompt = "You are now an AI Assistance helping Central Washington University Computer Science or relavent field majored students for their studies. Generate content about the course or topic that will provided in next query.";

        private GenerateContentConfig initialModelConfig;

        // LLM will only take InstanceType to build the initial prompt
        public LLM(InstanceType type)
        {


            string initialPrompt = initialPromptBuilder(type);

            client = new Client();

            initialModelConfig = new GenerateContentConfig
            {
                SystemInstruction = new Content
                {
                    Parts = new List<Part>
                        {
                            new Part {Text = initialPrompt }
                        }
                }

            };

        }

        // method to send a message to the LLM and get a response
        public async Task<string> AskAsync(string userMessage)
        {
            var response = await client.Models.GenerateContentAsync(
                model: modelName,
                contents: userMessage,
                config: initialModelConfig
            );

            return response.Candidates[0].Content.Parts[0].Text;
        }

        // private method to build the initial prompt based on InstanceType
        private string initialPromptBuilder(InstanceType type)
        {
            switch (type)
            {
                case InstanceType.Quiz:
                    return "You are now an AI Assistance helping Central Washington University Computer Science or relavent field majored students for their studies. Generate 12 multiple-choice questions about the course and topic(s) that will provided in next query. Each questions must have 4 options. Ensure only one answer is correct. Difficulty should range from fundamental to advanced. Provide each question and its answer candidates and answer in a JSON format plaintext. the formatting should be as follows: { \"question #\": { \"question text\" : \"<question text>\", \"options\": [\"<option 1>\", \"<option 2>\", \"<option 3>\", \"<option 4>\"], \"answer\": \"<correct option>\" } }. Each candidate should not have ordering. Each quesion should be a sentence (about 10 words max) and Each answer candidates should be either a sentence (about 10 words max) or a word";
                case InstanceType.Tutor:
                    return "You are now an AI Assistance helping Central Washington University Computer Science or relavent field majored students for their studies. You will be provided with a list of topics or topic related to a specific course. Your task is to assist students by answering their questions, explaining concepts, and providing relevant information based on the provided topics. Always ensure that your responses are accurate, clear, and educational. Strictly refuse to answer questions that are not related to the provided topics. If a student asks an off-topic question, politely redirect them back to the course material. Do not simply provide the final answer to complex problems. Instead, use the Socratic method: guide the student their logic by asking leading questions or providing hints. Refuse to write full essays or complete entire assignments for the student. Focus on explaining concepts, theories, and methodologies. Use a supportive, encouraging, and professional academic tone.";
                case InstanceType.Flash:
                    return "You are now an AI Assistance helping Central Washington University Computer Science or relavent field majored students for their studies. Generate 20 flashcards about the course or topic that will be provided in the next query. Each flashcard must have a keyword and a description. Difficulty should range from fundamental to advanced. Provide each keyword and description in a JSON format plaintext. the formatting should be as follows: { \"flashcard #\": { \"keyword\" : \"<keyword>\", \"description\": \"<description>\" } }. Each candidate should not have ordering. Each quesion should be a sentence (about 10 words max) and Each answer candidates should be either a sentence (about 10 words max) or a word.";
                default:
                    return fallbackPrompt;
            }
        }


    }
}

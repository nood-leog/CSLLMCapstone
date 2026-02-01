using System.Threading.Tasks;
using System.Collections.Generic;
using Google.GenAI;
using Google.GenAI.Types;
using CSLLMCapstone.Services;


namespace CSLLMCapstone.Models
{
    public class LLM
    {


        // do I want the LLM to be specific to an instance type when they are created? 
        // in that case, all I need is call the LLMService function with the llm instance. 
        // but then, for the topics, are we using same llm instance for multiple topics in the same course?
        // or should we create a new llm instance for each topic?
        // for sure, each instance type should have its own llm instance. 

        // I can just create the llm instance in each models so that it is specific to that instance type. 
        // in that case, LLMService is no longed needed
        // each model should have its own llm handlers.


        private Client client;
        private string modelName = "gemini-3-flash-preview";
        private string fallbackPrompt = "You are a helpful study assistant. Provide clear and concise answers to the user's questions based on general knowledge. ";
        private string initialPrompt = "";
        private GenerateContentConfig initialModelConfig;

        // Constructor to initialize LLM with specific instance type and course ID
        public LLM(InstanceType type, List<string>Topics)
        {

            switch (type)
            {
                case InstanceType.Quiz:
                    initialPrompt += initialPromptQuizBuilder(Topics);
                    break;
                case InstanceType.Tutor:
                    initialPrompt += initialPromptTutorBuilder(Topics);
                    break;
                case InstanceType.Flash:
                    initialPrompt += initialPromptFlashBuilder(Topics);
                    break;
                default:
                    initialPrompt += fallbackPrompt;
                    break;

            }


            /*
            if (type == InstanceType.Quiz)
            {
               initialPrompt = initialPromptQuizBuilder(courseId);
            }
            else if (type == InstanceType.Tutor)
            {
               initialPrompt = initialPromptTutorBuilder(courseId);
            }
            else if (type == InstanceType.Flash)
            {
               initialPrompt = initialPromptFlashBuilder(courseId); 
            }
            else
            {
                initialPrompt = fallbackPrompt;
            }
            */


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


        // Method to send a message to the LLM and get a response
        // This would be the bottom line method called by the service
        // In the case of Tutor mode, this function would be called directly? 
        public async Task<string> AskSync(string userMessage)
        {
            var response = await client.Models.GenerateContentAsync(
                model: modelName,
                contents: userMessage,
                config: initialModelConfig
            );

            return response.Candidates[0].Content.Parts[0].Text;

        }

        //TODO: Implement the methods to call LLM
        // call database service to get course info to build initial prompts

        private string initialPromptQuizBuilder(List<string> topics)
        {
            string QuizInitial = "constraints:\r\n\r\nGenerate exactly 12 multiple-choice questions.\r\nEach questions must have 4 options.\r\nEnsure only one answer is correct.\r\nDifficulty should range from foundational to advanced.\r\n\r\nformat:\r\n\r\nprovide each question and its answer candidates and answer in a single line with comma separated. \r\neach question should be line-spaced.\r\neach candidate should not have ordering.\r\nfor each question, answer should be placed after 4th candidate without ordering.\r\nprovide only plaintext.\r\n";

            string topicList = string.Join(",", topics);

            return $"{QuizInitial}\r\nTopics: {topicList}";
        }

        private string initialPromptTutorBuilder(List<string> topics)
        {
            string TutorInitial = "constraints:\r\n\r\nStrictly refuse to answer questions that are not related to topic or course.\r\nIf student asked an off-topic question, politely redirect them back to the course material.\r\nDo not simply provide the final answer to complex problems. Instead, use the Socratic method: guide the student through the logic by asking leading questions or providing hints.\r\nRefuse to write full essays or complete entire assignments for the student.\r\nFocus on explaining concepts, theories, and methodologies.\r\nUse supportive, encouraging, and professional academic tone. \r\n\r\nformat:\r\n\r\nprovide only plaintext.\r\nplease provide line-spacing between paragraphs.";

            string topicList = string.Join(",", topics);

            return $"{TutorInitial}\r\nTopics: {topicList}";
        }

        private string initialPromptFlashBuilder(List<string> topics)
        {
            string FlashInitial = "Generate exactly 20 keywords about the course or topic provided.\r\nGenerate exactly 20 descriptions for each keyword.\r\neach description should be a short paragraph.\r\nDifficulty should range from foundational to advanced.\r\n\r\nformat:\r\n\r\nprovide each keyword and description as plaintext in a single line with comma separated.\r\neach keyword should be line-spaced.\r\ncontents in each line should not have ordering.";

            string topicList = string.Join(",", topics);


            return $"{FlashInitial}\r\nTopics: {topicList}";
        }

        public static async Task<string> promptGenExample(string query)
        {

            if(query == null)
            {
                return "Error";
            }


            var client = new Client();
            var response = await client.Models.GenerateContentAsync(model: "gemini-3-flash-preview", contents: query);

            if(response.Candidates == null)
            {
                return "Error";
            }
            else
            {
                return response.Candidates[0].Content.Parts[0].Text;
            }

    

        }



    }
}

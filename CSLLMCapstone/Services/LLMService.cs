using CSLLMCapstone.Models;
using CSLLMCapstone.Data;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace CSLLMCapstone.Services
{
    public class LLMService
    {
        

        /*
        // idk what to do with this fuck
        public LLMService(InstanceType type, int courseId)
        {
           
            
        }

        */


        public async Task<List<Tuple<string, string>>> GenerateFlashCardData(LLM llm, string userMessage)
        {

            var finalRespons = new List<Tuple<string, string>>();
            // query llm to generate dataset as : keyword, definition  
            // example: OOP, Object Oriented Programming is a programming paradigm based on the concept of objects
            //          Encapsulation", "Encapsulation is the bundling of data with the methods that operate on that data
            // then, parse the response into a list of tuples

            return finalRespons;
        }


    }
}

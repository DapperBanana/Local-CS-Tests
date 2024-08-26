
using System;

namespace Chatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Chatbot! What would you like to talk about?");
            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                string response = GetResponse(userInput);
                Console.WriteLine(response);
                userInput = Console.ReadLine();
            }

            Console.WriteLine("Goodbye! Press any key to exit.");
            Console.ReadKey();
        }

        static string GetResponse(string input)
        {
            // Add your own responses here based on user input
            switch (input.ToLower())
            {
                case "hello":
                    return "Hello! How are you today?";
                case "how are you":
                    return "I'm just a computer program, so I'm always good!";
                case "what's your name":
                    return "I'm Chatbot!";
                default:
                    return "I'm sorry, I didn't understand that. Please try again.";
            }
        }
    }
}

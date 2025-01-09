
using System;

class Chatbot
{
    static void Main()
    {
        Console.WriteLine("Welcome to Chatbot! Type 'exit' to end the conversation.");
        
        while (true)
        {
            Console.Write("You: ");
            string userInput = Console.ReadLine();
            
            if (userInput.ToLower() == "exit")
            {
                Console.WriteLine("Chatbot: Goodbye!");
                break;
            }
            
            string response = GetResponse(userInput);
            Console.WriteLine("Chatbot: " + response);
        }
    }
    
    static string GetResponse(string input)
    {
        switch (input.ToLower())
        {
            case "hello":
                return "Hello! How can I assist you today?";
            case "how are you":
                return "I'm just a computer program, but thank you for asking!";
            case "what is your name":
                return "I'm Chatbot!";
            case "thank you":
                return "You're welcome!";
            default:
                return "I'm sorry, I don't understand. Can you please rephrase that?";
        }
    }
}

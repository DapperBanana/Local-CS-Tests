
using System;

class Chatbot
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Chatbot! How can I assist you?");
        
        while (true)
        {
            // Read user input
            string input = Console.ReadLine();
            
            // Generate response
            string response = GenerateResponse(input);
            
            // Output response
            Console.WriteLine(response);
        }
    }
    
    static string GenerateResponse(string input)
    {
        // Logic to generate response based on user input
        switch (input.ToLower())
        {
            case "hello":
                return "Hello! How are you today?";
            case "how are you":
                return "I'm just a computer program, but thank you for asking!";
            case "goodbye":
                return "Goodbye! Have a great day!";
            default:
                return "I'm sorry, I don't understand that command.";
        }
    }
}

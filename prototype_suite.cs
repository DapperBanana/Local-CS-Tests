
using System;

class Chatbot
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Chatbot! Type 'exit' to end the chat.");

        while (true)
        {
            Console.Write("You: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Chatbot: Goodbye! Have a nice day.");
                break;
            }

            string response = GetResponse(input);
            Console.WriteLine("Chatbot: " + response);
        }
    }

    public static string GetResponse(string input)
    {
        // Basic responses based on user input
        if (input.Contains("hello") || input.Contains("hi"))
        {
            return "Hello! How can I help you?";
        }
        else if (input.Contains("how are you"))
        {
            return "I'm just a computer program, but I'm here to assist you.";
        }
        else if (input.Contains("thank you") || input.Contains("thanks"))
        {
            return "You're welcome!";
        }
        else
        {
            return "I'm sorry, I don't understand. Can you please rephrase your question?";
        }
    }
}

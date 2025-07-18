
using System;

class Chatbot
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Chatbot! Type 'exit' to end the conversation.");

        while (true)
        {
            Console.Write("You: ");
            string userMessage = Console.ReadLine().ToLower();

            if (userMessage == "exit")
            {
                Console.WriteLine("Chatbot: Goodbye!");
                break;
            }

            string reply = GetResponse(userMessage);
            Console.WriteLine("Chatbot: " + reply);
        }
    }

    static string GetResponse(string userMessage)
    {
        if (userMessage.Contains("hello") || userMessage.Contains("hi"))
        {
            return "Hello! How can I help you?";
        }
        else if (userMessage.Contains("how are you"))
        {
            return "I'm just a computer program, but thanks for asking!";
        }
        else if (userMessage.Contains("bye"))
        {
            return "Goodbye! Have a great day!";
        }
        else
        {
            return "I'm sorry, I don't understand. Can you please rephrase?";
        }
    }
}

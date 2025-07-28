
using System;

class Chatbot
{
    static void Main()
    {
        Console.WriteLine("Chatbot: Hi there! How can I help you today?");
        Console.Write("You: ");

        string userMessage = Console.ReadLine();

        if (userMessage.ToLower() == "hello")
        {
            Console.WriteLine("Chatbot: Hello! How are you doing?");
        }
        else if (userMessage.ToLower() == "goodbye")
        {
            Console.WriteLine("Chatbot: Goodbye! Have a great day!");
        }
        else
        {
            Console.WriteLine("Chatbot: I'm sorry, I don't understand. Can you please rephrase?");
        }
    }
}

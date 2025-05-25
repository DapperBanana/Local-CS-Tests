
using System;

class Chatbot
{
    static void Main()
    {
        Console.WriteLine("Hello! I'm Chatbot. What's your name?");
        string name = Console.ReadLine();

        Console.WriteLine($"Nice to meet you, {name}! How can I help you today?");
        string input = Console.ReadLine();

        while (input.ToLower() != "bye")
        {
            Console.WriteLine($"You said: {input}");
            Console.WriteLine("Sorry, I'm just a basic chatbot. I don't understand much.");
            Console.WriteLine("How can I help you today?");
            input = Console.ReadLine();
        }

        Console.WriteLine("Goodbye! Feel free to chat with me again.");
    }
}

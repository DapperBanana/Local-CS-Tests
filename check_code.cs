
using System;

class Chatbot
{
    static void Main()
    {
        Console.WriteLine("Hi, I'm Chatbot. What's your name?");
        string name = Console.ReadLine();

        Console.WriteLine($"Nice to meet you, {name}. How can I help you today?");

        bool chatting = true;

        while (chatting)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "bye")
            {
                Console.WriteLine("Goodbye! Have a great day.");
                chatting = false;
            }
            else
            {
                Console.WriteLine("Sorry, I don't understand. Can you please ask me something else?");
            }
        }
    }
}


using System;

class Chatbot
{
    static void Main()
    {
        Console.WriteLine("Hello! I am a chatbot. What is your name?");
        string name = Console.ReadLine();

        Console.WriteLine($"Nice to meet you, {name}! How can I help you today?");

        while (true)
        {
            string userInput = Console.ReadLine();

            if (userInput.ToLower().Contains("hello") || userInput.ToLower().Contains("hi"))
            {
                Console.WriteLine("Hello there!");
            }
            else if(userInput.ToLower().Contains("how are you"))
            {
                Console.WriteLine("I am just a computer program, but thank you for asking!");
            }
            else if (userInput.ToLower().Contains("exit") || userInput.ToLower().Contains("bye"))
            {
                Console.WriteLine("Goodbye! Have a great day!");
                break;
            }
            else
            {
                Console.WriteLine("I'm sorry, I don't understand. Can you repeat that?");
            }
        }
    }
}


using System;

class Chatbot
{
    static void Main()
    {
        Console.WriteLine("Hello! I am your chatbot. What can I help you with today?");

        while (true)
        {
            Console.Write("You: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "hello")
            {
                Console.WriteLine("Chatbot: Hello! How are you today?");
            }
            else if (input.ToLower() == "what is your name?")
            {
                Console.WriteLine("Chatbot: My name is Chatbot. Nice to meet you!");
            }
            else if (input.ToLower() == "exit")
            {
                Console.WriteLine("Chatbot: Goodbye! Have a great day.");
                break;
            }
            else
            {
                Console.WriteLine("Chatbot: I'm sorry, I didn't understand that. Can you please repeat?");
            }
        }
    }
}

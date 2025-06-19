
using System;

class Chatbot
{
    static void Main()
    {
        Console.WriteLine("Hello! I am your friendly chatbot. What's your name?");
        string name = Console.ReadLine();

        Console.WriteLine($"Nice to meet you, {name}! How can I assist you today?");

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Goodbye! Have a great day.");
                break;
            }

            string response = GetResponse(input);
            Console.WriteLine(response);
        }
    }

    static string GetResponse(string input)
    {
        // Add your own responses here
        if (input.Contains("hello") || input.Contains("hi"))
        {
            return "Hello! How are you?";
        }
        else if (input.Contains("how are you"))
        {
            return "I'm just a computer program, so I'm always good!";
        }
        else if (input.Contains("weather"))
        {
            return "I'm sorry, I cannot provide weather information. You can check online for the latest weather updates.";
        }
        else
        {
            return "I'm sorry, I don't understand. Can you please rephrase your question?";
        }
    }
}

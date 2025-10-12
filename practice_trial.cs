
using System;

class Chatbot
{
    static void Main()
    {
        Console.WriteLine("Hello! I am a chatbot. What's your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Nice to meet you, " + name + "! How can I help you today?");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Goodbye, " + name + "! Have a great day.");
                break;
            }
            else
            {
                string response = GenerateResponse(input);
                Console.WriteLine(response);
            }
        }
    }

    static string GenerateResponse(string input)
    {
        // Add more responses or logic here to make the chatbot more engaging
        switch (input.ToLower())
        {
            case "hi":
            case "hello":
                return "Hi there! How can I assist you today?";
            case "how are you":
                return "I am just a chatbot, but thanks for asking!";
            case "what is your name":
                return "I am Chatbot. Nice to talk with you!";
            default:
                return "I'm not sure how to respond to that. Can you please clarify?";
        }
    }
}

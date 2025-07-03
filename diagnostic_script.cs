
using System;

class Chatbot
{
    static void Main()
    {
        Console.WriteLine("Hello! I am your chatbot. How can I assist you today?");
        
        while (true)
        {
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
            {
                Console.WriteLine("Goodbye! Have a great day.");
                break;
            }
            else
            {
                string response = GetChatbotResponse(userInput);
                Console.WriteLine(response);
            }
        }
    }

    private static string GetChatbotResponse(string userInput)
    {
        // Add more responses or logic here based on user input
        if (userInput.Contains("hello"))
        {
            return "Hello! How can I help you?";
        }
        else if (userInput.Contains("how are you"))
        {
            return "I'm just a program, so I'm good. How can I assist you?";
        }
        else
        {
            return "I'm sorry, I don't understand. Can you please rephrase your question?";
        }
    }
}

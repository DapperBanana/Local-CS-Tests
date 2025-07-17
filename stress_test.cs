
using System;

class Chatbot
{
    static void Main()
    {
        Console.WriteLine("Hello! I'm Chatbot. What's your name?");
        string userName = Console.ReadLine();

        Console.WriteLine($"Nice to meet you, {userName}! How can I help you today?");
        Console.WriteLine("(Type 'exit' to end the conversation)");

        while (true)
        {
            string userInput = Console.ReadLine();
            
            if (userInput.ToLower() == "exit")
            {
                break;
            }

            string response = GetChatbotResponse(userInput);
            Console.WriteLine(response);
        }

        Console.WriteLine("Goodbye! Have a great day.");
    }

    static string GetChatbotResponse(string input)
    {
        // Simple chatbot responses based on user input
        if (input.Contains("hello") || input.Contains("hi"))
        {
            return "Hello! How are you today?";
        }
        else if (input.Contains("how are you"))
        {
            return "I'm just a chatbot, I don't have feelings. But thanks for asking!";
        }
        else if (input.Contains("thank you"))
        {
            return "You're welcome! Is there anything else I can help with?";
        }
        else
        {
            return "I'm sorry, I don't understand. Can you rephrase or ask me something else?";
        }
    }
}


using System;

class Chatbot
{
    static void Main()
    {
        Console.WriteLine("Hello! I am a chatbot. What is your name?");
        string userName = Console.ReadLine();

        Console.WriteLine($"Nice to meet you, {userName}. How can I help you today?");
        
        bool chatting = true;
        
        while(chatting)
        {
            string userMessage = Console.ReadLine();

            if(userMessage.ToLower() == "exit")
            {
                Console.WriteLine("Goodbye! Have a great day.");
                chatting = false;
            }
            else
            {
                string response = GenerateResponse(userMessage);
                Console.WriteLine(response);
            }
        }
    }

    static string GenerateResponse(string message)
    {
        // Implement basic response generation logic here
        if(message.ToLower().Contains("hello") || message.ToLower().Contains("hi"))
        {
            return "Hello there!";
        }
        else if(message.ToLower().Contains("how are you"))
        {
            return "I'm just a chatbot, I don't have feelings. But thank you for asking!";
        }
        else
        {
            return "I'm sorry, I didn't quite understand that. Can you please rephrase your question?";
        }
    }
}

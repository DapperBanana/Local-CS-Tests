
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
            string response = GetResponse(userInput);
            
            Console.WriteLine(response);
        }
    }
    
    static string GetResponse(string input)
    {
        if (input.ToLower().Contains("hello") || input.ToLower().Contains("hi"))
        {
            return "Hello! How are you?";
        }
        else if (input.ToLower().Contains("good") || input.ToLower().Contains("fine"))
        {
            return "That's great to hear!";
        }
        else if (input.ToLower().Contains("bad") || input.ToLower().Contains("not good"))
        {
            return "I'm sorry to hear that. Is there anything I can do to help?";
        }
        else
        {
            return "I'm sorry, I don't understand. Can you please rephrase or ask a different question?";
        }
    }
}

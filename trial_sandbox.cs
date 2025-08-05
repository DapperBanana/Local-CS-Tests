
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Personality Quiz!");
        Console.WriteLine("Answer the following questions:");
        
        int score = 0;
        
        Console.WriteLine("1. Are you more introverted or extroverted?");
        string answer1 = Console.ReadLine();
        if(answer1.ToLower() == "introverted")
        {
            score++;
        }
        
        Console.WriteLine("2. Do you prefer to plan things out or go with the flow?");
        string answer2 = Console.ReadLine();
        if(answer2.ToLower() == "plan things out")
        {
            score++;
        }
        
        Console.WriteLine("3. Are you more analytical or creative?");
        string answer3 = Console.ReadLine();
        if(answer3.ToLower() == "analytical")
        {
            score++;
        }
        
        Console.WriteLine("Your personality type is:");
        
        if(score >= 2)
        {
            Console.WriteLine("You are a logical and introverted person.");
        }
        else
        {
            Console.WriteLine("You are a creative and extroverted person.");
        }
    }
}


using System;

class PersonalityQuiz
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Personality Quiz!");
        Console.WriteLine("Answer the following questions with either 'yes' or 'no'.");
        
        Console.WriteLine("Question 1: Are you an outgoing person?");
        string answer1 = Console.ReadLine();
        if (answer1.ToLower() == "yes")
        {
            score += 1;
        }

        Console.WriteLine("Question 2: Do you enjoy spending time alone?");
        string answer2 = Console.ReadLine();
        if (answer2.ToLower() == "yes")
        {
            score += 1;
        }

        Console.WriteLine("Question 3: Are you a creative person?");
        string answer3 = Console.ReadLine();
        if (answer3.ToLower() == "yes")
        {
            score += 1;
        }

        Console.WriteLine("Question 4: Do you enjoy trying new things?");
        string answer4 = Console.ReadLine();
        if (answer4.ToLower() == "yes")
        {
            score += 1;
        }

        Console.WriteLine("Question 5: Do you prefer to plan things in advance?");
        string answer5 = Console.ReadLine();
        if (answer5.ToLower() == "yes")
        {
            score += 1;
        }

        if (score >= 3)
        {
            Console.WriteLine("You are an adventurous person!");
        }
        else
        {
            Console.WriteLine("You are a more reserved person.");
        }
    }
}

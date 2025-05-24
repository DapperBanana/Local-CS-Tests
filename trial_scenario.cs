
using System;

class PersonalityQuiz
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Personality Quiz!");
        
        int score = 0;

        Console.WriteLine("Question 1: What is your favorite color?");
        Console.WriteLine("a) Blue");
        Console.WriteLine("b) Red");
        Console.WriteLine("c) Green");

        string answer1 = Console.ReadLine();
        
        if (answer1 == "a")
        {
            score += 1;
        }
        else if (answer1 == "b")
        {
            score += 2;
        }
        else if (answer1 == "c")
        {
            score += 3;
        }

        Console.WriteLine("Question 2: What is your favorite animal?");
        Console.WriteLine("a) Dog");
        Console.WriteLine("b) Cat");
        Console.WriteLine("c) Bird");

        string answer2 = Console.ReadLine();
        
        if (answer2 == "a")
        {
            score += 1;
        }
        else if (answer2 == "b")
        {
            score += 2;
        }
        else if (answer2 == "c")
        {
            score += 3;
        }

        Console.WriteLine("Question 3: What is your favorite hobby?");
        Console.WriteLine("a) Reading");
        Console.WriteLine("b) Playing sports");
        Console.WriteLine("c) Drawing");

        string answer3 = Console.ReadLine();
        
        if (answer3 == "a")
        {
            score += 1;
        }
        else if (answer3 == "b")
        {
            score += 2;
        }
        else if (answer3 == "c")
        {
            score += 3;
        }

        Console.WriteLine("Your personality type is: ");

        if (score <= 3)
        {
            Console.WriteLine("You are introverted and enjoy quiet activities.");
        }
        else if (score <= 6)
        {
            Console.WriteLine("You are outgoing and enjoy active pursuits.");
        }
        else
        {
            Console.WriteLine("You are creative and enjoy artistic endeavors.");
        }
    }
}

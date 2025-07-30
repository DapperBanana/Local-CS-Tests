
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Personality Quiz!");

        // Questions for the user to answer
        Console.WriteLine("Question 1: What is your favorite color?");
        string answer1 = Console.ReadLine();

        Console.WriteLine("Question 2: What is your favorite animal?");
        string answer2 = Console.ReadLine();

        Console.WriteLine("Question 3: What is your favorite season?");
        string answer3 = Console.ReadLine();

        // Determine the personality type based on answers
        string personalityType = DeterminePersonalityType(answer1, answer2, answer3);

        Console.WriteLine($"Your personality type is: {personalityType}");
    }

    static string DeterminePersonalityType(string color, string animal, string season)
    {
        if (color.ToLower() == "blue" && animal.ToLower() == "dog" && season.ToLower() == "summer")
        {
            return "You are an outgoing and friendly person!";
        }
        else if (color.ToLower() == "green" && animal.ToLower() == "cat" && season.ToLower() == "fall")
        {
            return "You are a calm and introspective person!";
        }
        else
        {
            return "Your personality type is difficult to determine. Please try again!";
        }
    }
}

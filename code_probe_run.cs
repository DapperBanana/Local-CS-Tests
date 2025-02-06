
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Personality Quiz!");

        Console.WriteLine("What is your favorite color?");
        string color = Console.ReadLine().ToLower();

        Console.WriteLine("What is your favorite animal?");
        string animal = Console.ReadLine().ToLower();

        Console.WriteLine("What is your favorite season?");
        string season = Console.ReadLine().ToLower();

        Console.WriteLine("What is your favorite food?");
        string food = Console.ReadLine().ToLower();

        int score = 0;

        if (color == "blue" || color == "green")
        {
            score += 1;
        }

        if (animal == "dog" || animal == "cat")
        {
            score += 1;
        }

        if (season == "spring" || season == "fall")
        {
            score += 1;
        }

        if (food == "pizza" || food == "pasta")
        {
            score += 1;
        }

        if (score < 2)
        {
            Console.WriteLine("Your personality type is: Introvert");
        }
        else if (score == 2)
        {
            Console.WriteLine("Your personality type is: Ambivert");
        }
        else
        {
            Console.WriteLine("Your personality type is: Extrovert");
        }
    }
}

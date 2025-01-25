
using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Educational Quiz!");
        Console.WriteLine("Answer the questions below to test your knowledge.\n");

        // Question 1
        Console.WriteLine("What is the capital city of France?");
        string answer1 = Console.ReadLine();
        if (answer1.ToLower() == "paris")
        {
            Console.WriteLine("Correct!\n");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is Paris.\n");
        }

        // Question 2
        Console.WriteLine("What is the tallest mountain in the world?");
        string answer2 = Console.ReadLine();
        if (answer2.ToLower() == "mount everest")
        {
            Console.WriteLine("Correct!\n");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is Mount Everest.\n");
        }

        // Question 3
        Console.WriteLine("How many continents are there in the world?");
        string answer3 = Console.ReadLine();
        if (answer3 == "7")
        {
            Console.WriteLine("Correct!\n");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is 7.\n");
        }

        // Display final score
        Console.WriteLine("Quiz complete! You got " + score + " out of 3 questions correct.");
    }
}

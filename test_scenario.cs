
using System;

class Program
{
    static void Main()
    {
        int score = 0;

        // Question 1
        Console.WriteLine("What is the capital of France?");
        string answer1 = Console.ReadLine();
        if (answer1.ToLower() == "paris")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is Paris.");
        }

        // Question 2
        Console.WriteLine("What is the largest planet in our solar system?");
        string answer2 = Console.ReadLine();
        if (answer2.ToLower() == "jupiter")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is Jupiter.");
        }

        // Question 3
        Console.WriteLine("What is the powerhouse of the cell?");
        string answer3 = Console.ReadLine();
        if (answer3.ToLower() == "mitochondria")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is mitochondria.");
        }

        Console.WriteLine($"Quiz complete! You scored {score} out of 3.");
    }
}

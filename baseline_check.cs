
using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Educational Quiz!");
        Console.WriteLine("Answer the following questions:");

        // Question 1
        Console.WriteLine("1. What is the capital of France?");
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
        Console.WriteLine("2. What is the largest planet in our solar system?");
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
        Console.WriteLine("3. Who painted the Mona Lisa?");
        string answer3 = Console.ReadLine();
        if (answer3.ToLower() == "leonardo da vinci")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is Leonardo da Vinci.");
        }

        // Display final score
        Console.WriteLine($"Your score is: {score} out of 3");

        if (score == 3)
        {
            Console.WriteLine("Congratulations! You got a perfect score!");
        }
    }
}

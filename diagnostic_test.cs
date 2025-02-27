
using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Basic Quiz!");
        Console.WriteLine();

        // Question 1
        Console.WriteLine("Question 1: What is the capital of France?");
        Console.WriteLine("A. London");
        Console.WriteLine("B. Paris");
        Console.WriteLine("C. Berlin");
        Console.WriteLine("D. Rome");
        Console.Write("Your answer: ");
        string answer1 = Console.ReadLine();

        if (answer1.ToUpper() == "B")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is B. Paris.");
        }

        // Question 2
        Console.WriteLine();
        Console.WriteLine("Question 2: What is the largest planet in our solar system?");
        Console.WriteLine("A. Venus");
        Console.WriteLine("B. Jupiter");
        Console.WriteLine("C. Earth");
        Console.WriteLine("D. Mars");
        Console.Write("Your answer: ");
        string answer2 = Console.ReadLine();

        if (answer2.ToUpper() == "B")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is B. Jupiter.");
        }

        // Display final score
        Console.WriteLine();
        Console.WriteLine("Quiz complete. Your score is: " + score + "/2");

        Console.ReadLine();
    }
}

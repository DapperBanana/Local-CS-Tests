
using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Educational Quiz!");
        Console.WriteLine("Answer the following questions with the correct letter (A, B, C, or D).");

        // Question 1
        Console.WriteLine("\n1. What is the capital of France?");
        Console.WriteLine("A. London");
        Console.WriteLine("B. Rome");
        Console.WriteLine("C. Paris");
        Console.WriteLine("D. Madrid");
        Console.Write("Your answer: ");
        string answer1 = Console.ReadLine();

        if (answer1.ToUpper() == "C")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is C. Paris");
        }

        // Question 2
        Console.WriteLine("\n2. What is the largest planet in our solar system?");
        Console.WriteLine("A. Mars");
        Console.WriteLine("B. Jupiter");
        Console.WriteLine("C. Earth");
        Console.WriteLine("D. Venus");
        Console.Write("Your answer: ");
        string answer2 = Console.ReadLine();

        if (answer2.ToUpper() == "B")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is B. Jupiter");
        }

        Console.WriteLine($"\nYou got {score} out of 2 questions correct.");
    }
}

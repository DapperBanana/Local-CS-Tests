
using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Quiz!");
        Console.WriteLine("Question 1: What is the capital of France?");
        Console.WriteLine("A. London");
        Console.WriteLine("B. Paris");
        Console.WriteLine("C. Berlin");
        Console.WriteLine("D. Madrid");

        Console.Write("Your answer: ");
        string answer1 = Console.ReadLine();

        if (answer1.ToUpper() == "B")
        {
            score++;
        }

        Console.WriteLine("\nQuestion 2: What is 2 + 2?");
        Console.WriteLine("A. 3");
        Console.WriteLine("B. 4");
        Console.WriteLine("C. 5");
        Console.WriteLine("D. 6");

        Console.Write("Your answer: ");
        string answer2 = Console.ReadLine();

        if (answer2.ToUpper() == "B")
        {
            score++;
        }

        Console.WriteLine($"\nQuiz completed! You scored {score}/2.");
    }
}

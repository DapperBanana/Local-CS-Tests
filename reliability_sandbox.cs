
using System;

class Quiz
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Basic Quiz!");
        Console.WriteLine("Answer the following questions:");

        Console.WriteLine("Question 1: What is the capital of France?");
        Console.WriteLine("A) London");
        Console.WriteLine("B) Paris");
        Console.WriteLine("C) Rome");
        Console.WriteLine("D) Madrid");
        string answer1 = Console.ReadLine().ToUpper();
        if (answer1 == "B")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

        Console.WriteLine("Question 2: What is the largest planet in our solar system?");
        Console.WriteLine("A) Earth");
        Console.WriteLine("B) Mars");
        Console.WriteLine("C) Jupiter");
        Console.WriteLine("D) Saturn");
        string answer2 = Console.ReadLine().ToUpper();
        if (answer2 == "C")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

        Console.WriteLine("Your score is: " + score + " out of 2");
    }
}

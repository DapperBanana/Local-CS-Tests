
using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Educational Quiz!");
        Console.WriteLine("Answer the following questions to test your knowledge!");

        // Question 1
        Console.WriteLine("\nQuestion 1: What is the capital of France?");
        Console.WriteLine("A. London");
        Console.WriteLine("B. Paris");
        Console.WriteLine("C. Rome");

        string answer1 = Console.ReadLine();
        if (answer1.ToUpper() == "B")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

        // Question 2
        Console.WriteLine("\nQuestion 2: How many sides does a triangle have?");
        Console.WriteLine("A. 2");
        Console.WriteLine("B. 3");
        Console.WriteLine("C. 4");

        string answer2 = Console.ReadLine();
        if (answer2.ToUpper() == "B")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

        // Question 3
        Console.WriteLine("\nQuestion 3: Who wrote 'Romeo and Juliet'?");
        Console.WriteLine("A. William Shakespeare");
        Console.WriteLine("B. Jane Austen");
        Console.WriteLine("C. Charles Dickens");

        string answer3 = Console.ReadLine();
        if (answer3.ToUpper() == "A")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

        Console.WriteLine("\nQuiz complete! You scored: " + score + " out of 3");
    }
}

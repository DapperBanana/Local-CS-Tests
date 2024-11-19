
using System;

class Quiz
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Quiz!");
        Console.WriteLine("Answer the following questions by entering the option number (e.g. 1, 2, 3, 4)");

        // Question 1
        Console.WriteLine("1. What is the capital of France?");
        Console.WriteLine("1. London");
        Console.WriteLine("2. Berlin");
        Console.WriteLine("3. Paris");
        Console.WriteLine("4. Madrid");
        int answer1 = int.Parse(Console.ReadLine());
        if (answer1 == 3)
        {
            score++;
        }

        // Question 2
        Console.WriteLine("2. Who wrote Romeo and Juliet?");
        Console.WriteLine("1. William Shakespeare");
        Console.WriteLine("2. Jane Austen");
        Console.WriteLine("3. Charles Dickens");
        Console.WriteLine("4. Oscar Wilde");
        int answer2 = int.Parse(Console.ReadLine());
        if (answer2 == 1)
        {
            score++;
        }

        // Question 3
        Console.WriteLine("3. What is the largest planet in our solar system?");
        Console.WriteLine("1. Earth");
        Console.WriteLine("2. Jupiter");
        Console.WriteLine("3. Mars");
        Console.WriteLine("4. Saturn");
        int answer3 = int.Parse(Console.ReadLine());
        if (answer3 == 2)
        {
            score++;
        }

        // Display final score
        Console.WriteLine("Quiz complete!");
        Console.WriteLine("Your score is: " + score + "/3");
    }
}


using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Educational Quiz!");
        Console.WriteLine("Answer the following questions to test your knowledge.\n");

        // Question 1
        Console.WriteLine("Question 1: What is the capital of France?");
        Console.WriteLine("A) London");
        Console.WriteLine("B) Paris");
        Console.WriteLine("C) Rome");
        string answer1 = Console.ReadLine().ToUpper();
        if (answer1 == "B")
        {
            Console.WriteLine("Correct!\n");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is B) Paris.\n");
        }

        // Question 2
        Console.WriteLine("Question 2: What is the largest planet in our solar system?");
        Console.WriteLine("A) Earth");
        Console.WriteLine("B) Jupiter");
        Console.WriteLine("C) Mars");
        string answer2 = Console.ReadLine().ToUpper();
        if (answer2 == "B")
        {
            Console.WriteLine("Correct!\n");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is B) Jupiter.\n");
        }

        // Display final score
        Console.WriteLine("Quiz complete! Your final score is: " + score + "/2");
    }
}

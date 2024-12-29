
using System;

class QuizProgram
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Educational Quiz!");

        Console.WriteLine("Question 1: What is the capital of France?");
        Console.WriteLine("A. London");
        Console.WriteLine("B. Paris");
        Console.WriteLine("C. Berlin");

        Console.Write("Your answer: ");
        string answer1 = Console.ReadLine();

        if (answer1.ToUpper() == "B")
        {
            Console.WriteLine("Correct!\n");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect.\n");
        }

        Console.WriteLine("Question 2: What is the largest planet in our solar system?");
        Console.WriteLine("A. Venus");
        Console.WriteLine("B. Jupiter");
        Console.WriteLine("C. Mars");

        Console.Write("Your answer: ");
        string answer2 = Console.ReadLine();

        if (answer2.ToUpper() == "B")
        {
            Console.WriteLine("Correct!\n");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect.\n");
        }

        Console.WriteLine("Your final score is: " + score + "/2");

        Console.WriteLine("Thank you for playing the Educational Quiz!");
    }
}

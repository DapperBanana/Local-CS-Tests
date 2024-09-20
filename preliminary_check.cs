
using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Educational Quiz!\n");

        Console.WriteLine("Question 1: What is the capital of France?");
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

        Console.WriteLine("\nQuestion 2: What is the powerhouse of the cell?");
        string answer2 = Console.ReadLine();
        if (answer2.ToLower() == "mitochondria")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is mitochondria.");
        }

        Console.WriteLine("\nQuestion 3: Who wrote Romeo and Juliet?");
        string answer3 = Console.ReadLine();
        if (answer3.ToLower() == "shakespeare" || answer3.ToLower() == "william shakespeare")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is Shakespeare or William Shakespeare.");
        }

        Console.WriteLine($"\nYou've completed the quiz! Your final score is {score}/3");

        if (score == 3)
        {
            Console.WriteLine("Congratulations! You got a perfect score!");
        }
        else if (score >= 2)
        {
            Console.WriteLine("Well done!");
        }
        else
        {
            Console.WriteLine("You can do better next time.");
        }
    }
}

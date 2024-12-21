
using System;

class Program
{
    static void Main(string[] args)
    {
        int score = 0;

        Console.WriteLine("Welcome to the Educational Quiz!");
        Console.WriteLine("Answer the following questions to test your knowledge.");

        // Question 1
        Console.WriteLine("\nQuestion 1: What is the capital of France?");
        string answer1 = Console.ReadLine();
        if (answer1.ToLower() == "paris")
        {
            score++;
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is Paris.");
        }

        // Question 2
        Console.WriteLine("\nQuestion 2: How many continents are there in the world?");
        string answer2 = Console.ReadLine();
        if (answer2 == "7")
        {
            score++;
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is 7.");
        }

        // Question 3
        Console.WriteLine("\nQuestion 3: What is the largest mammal on Earth?");
        string answer3 = Console.ReadLine();
        if (answer3.ToLower() == "blue whale")
        {
            score++;
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is Blue Whale.");
        }

        Console.WriteLine($"\nQuiz completed! Your score is: {score}/3");

        if(score >= 2)
        {
            Console.WriteLine("Well done! You passed the quiz.");
        }
        else
        {
            Console.WriteLine("You need to study more. Better luck next time!");
        }
    }
}

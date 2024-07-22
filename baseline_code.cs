
using System;

class Program
{
    static void Main()
    {
        string question1 = "What is the capital of France?";
        string question2 = "What year did Christopher Columbus discover America?";
        
        string answer1 = "Paris";
        string answer2 = "1492";

        Console.WriteLine("Welcome to the Educational Quiz!");
        Console.WriteLine("-----------------------------------");

        Console.WriteLine(question1);
        string userAnswer1 = Console.ReadLine();

        if (userAnswer1.ToLower() == answer1.ToLower())
        {
            Console.WriteLine("Correct!\n");
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is Paris.\n");
        }

        Console.WriteLine(question2);
        string userAnswer2 = Console.ReadLine();

        if (userAnswer2 == answer2)
        {
            Console.WriteLine("Correct!\n");
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is 1492.\n");
        }

        Console.WriteLine("Thank you for taking the quiz!");
    }
}

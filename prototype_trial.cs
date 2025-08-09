
using System;

class Quiz
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Basic Quiz!");

        Console.WriteLine("Question 1: What is the capital of France?");
        Console.WriteLine("A) London");
        Console.WriteLine("B) Paris");
        Console.WriteLine("C) Berlin");
        Console.WriteLine("D) Rome");

        string answer1 = Console.ReadLine();

        if (answer1.ToUpper() == "B")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is B) Paris");
        }

        Console.WriteLine("Question 2: What is the largest mammal on Earth?");
        Console.WriteLine("A) Elephant");
        Console.WriteLine("B) Blue Whale");
        Console.WriteLine("C) Giraffe");
        Console.WriteLine("D) Lion");

        string answer2 = Console.ReadLine();

        if (answer2.ToUpper() == "B")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is B) Blue Whale");
        }

        Console.WriteLine("Your final score is: " + score + "/2");

        if (score == 2)
        {
            Console.WriteLine("Congratulations, you got a perfect score!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}

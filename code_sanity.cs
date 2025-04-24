
using System;

class Quiz
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Basic Quiz!");
        int score = 0;

        // Question 1
        Console.WriteLine("1. What is the capital of France?");
        Console.WriteLine("A. London");
        Console.WriteLine("B. Rome");
        Console.WriteLine("C. Paris");
        string answer1 = Console.ReadLine();
        if (answer1.ToUpper() == "C")
        {
            score++;
        }
        
        // Question 2
        Console.WriteLine("2. What is the largest mammal?");
        Console.WriteLine("A. Elephant");
        Console.WriteLine("B. Blue whale");
        Console.WriteLine("C. Lion");
        string answer2 = Console.ReadLine();
        if (answer2.ToUpper() == "B")
        {
            score++;
        }
        
        // Question 3
        Console.WriteLine("3. What is the capital of Japan?");
        Console.WriteLine("A. Beijing");
        Console.WriteLine("B. Tokyo");
        Console.WriteLine("C. Bangkok");
        string answer3 = Console.ReadLine();
        if (answer3.ToUpper() == "B")
        {
            score++;
        }

        Console.WriteLine($"Your score is: {score}/3");
        
        if (score == 3)
        {
            Console.WriteLine("Congratulations! You got all the questions correct!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}

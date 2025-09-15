
using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Educational Quiz!");
        Console.WriteLine("Answer the following questions with A, B, C, or D.\n");

        // Question 1
        Console.WriteLine("1. What is the capital of France?");
        Console.WriteLine("A. London");
        Console.WriteLine("B. Madrid");
        Console.WriteLine("C. Paris");
        Console.WriteLine("D. Rome");
        string answer1 = Console.ReadLine();
        if (answer1.ToUpper() == "C")
        {
            score++;
        }

        // Question 2
        Console.WriteLine("\n2. In which year did World War II end?");
        Console.WriteLine("A. 1945");
        Console.WriteLine("B. 1918");
        Console.WriteLine("C. 1939");
        Console.WriteLine("D. 1941");
        string answer2 = Console.ReadLine();
        if (answer2.ToUpper() == "A")
        {
            score++;
        }

        Console.WriteLine($"\nYou scored {score} out of 2.");
        if (score == 2)
        {
            Console.WriteLine("Congratulations! You got a perfect score!");
        }
        else
        {
            Console.WriteLine("Keep studying, you can do better next time!");
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        int score = 0;

        // Question 1
        Console.WriteLine("What is the capital of France?");
        Console.WriteLine("A. London");
        Console.WriteLine("B. Berlin");
        Console.WriteLine("C. Paris");
        string answer1 = Console.ReadLine();
        if (answer1.ToUpper() == "C")
        {
            score++;
        }

        // Question 2
        Console.WriteLine("What is 2 + 2?");
        Console.WriteLine("A. 3");
        Console.WriteLine("B. 4");
        Console.WriteLine("C. 5");
        string answer2 = Console.ReadLine();
        if (answer2.ToUpper() == "B")
        {
            score++;
        }

        // Question 3
        Console.WriteLine("Which planet is known as the Red Planet?");
        Console.WriteLine("A. Earth");
        Console.WriteLine("B. Mars");
        Console.WriteLine("C. Saturn");
        string answer3 = Console.ReadLine();
        if (answer3.ToUpper() == "B")
        {
            score++;
        }

        // Display score
        Console.WriteLine("Quiz completed! Your score is: " + score);
    }
}

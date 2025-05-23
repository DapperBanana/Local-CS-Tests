
using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Educational Quiz! Let's begin.\n");

        Console.WriteLine("Question 1: What is the capital of France?");
        Console.WriteLine("A. London");
        Console.WriteLine("B. Paris");
        Console.WriteLine("C. Rome");
        Console.WriteLine("D. Berlin");

        Console.Write("Enter your answer (A, B, C, or D): ");
        string answer1 = Console.ReadLine();

        if(answer1.ToUpper() == "B")
        {
            Console.WriteLine("Correct!\n");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is B.\n");
        }

        Console.WriteLine("Question 2: What is the powerhouse of the cell?");
        Console.WriteLine("A. Mitochondria");
        Console.WriteLine("B. Golgi Apparatus");
        Console.WriteLine("C. Endoplasmic Reticulum");
        Console.WriteLine("D. Lysosome");

        Console.Write("Enter your answer (A, B, C, or D): ");
        string answer2 = Console.ReadLine();

        if(answer2.ToUpper() == "A")
        {
            Console.WriteLine("Correct!\n");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is A.\n");
        }

        Console.WriteLine("Quiz complete! You scored {0} out of 2.", score);
    }
}

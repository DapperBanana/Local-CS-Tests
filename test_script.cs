
using System;

class Program
{
    static void Main()
    {
        int score = 0;
        
        Console.WriteLine("Welcome to the Educational Quiz!");
        
        Console.WriteLine("Question 1: What is the capital of France?");
        Console.WriteLine("A. London");
        Console.WriteLine("B. Paris");
        Console.WriteLine("C. Berlin");
        Console.WriteLine("D. Rome");
        char answer1 = char.Parse(Console.ReadLine());
        if (answer1 == 'B' || answer1 == 'b')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is B. Paris");
        }
        
        Console.WriteLine("Question 2: What is 2 + 2?");
        Console.WriteLine("A. 3");
        Console.WriteLine("B. 4");
        Console.WriteLine("C. 5");
        Console.WriteLine("D. 6");
        char answer2 = char.Parse(Console.ReadLine());
        if (answer2 == 'B' || answer2 == 'b')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is B. 4");
        }

        Console.WriteLine("You scored " + score + " out of 2 questions.");

    }
}

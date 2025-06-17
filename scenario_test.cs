
using System;

namespace BasicQuizSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("Welcome to the Basic Quiz!");
            Console.WriteLine("Answer the following multiple-choice questions:");
            Console.WriteLine();

            // Question 1
            Console.WriteLine("1. What is the capital of France?");
            Console.WriteLine("A. Madrid");
            Console.WriteLine("B. London");
            Console.WriteLine("C. Paris");
            Console.WriteLine("D. Rome");

            string answer1 = Console.ReadLine();
            if (answer1.ToUpper() == "C")
            {
                score++;
            }

            // Question 2
            Console.WriteLine();
            Console.WriteLine("2. What is the largest planet in our solar system?");
            Console.WriteLine("A. Earth");
            Console.WriteLine("B. Jupiter");
            Console.WriteLine("C. Saturn");
            Console.WriteLine("D. Mars");

            string answer2 = Console.ReadLine();
            if (answer2.ToUpper() == "B")
            {
                score++;
            }

            // Question 3
            Console.WriteLine();
            Console.WriteLine("3. Who wrote the play 'Romeo and Juliet'?");
            Console.WriteLine("A. William Shakespeare");
            Console.WriteLine("B. Charles Dickens");
            Console.WriteLine("C. Jane Austen");
            Console.WriteLine("D. Mark Twain");

            string answer3 = Console.ReadLine();
            if (answer3.ToUpper() == "A")
            {
                score++;
            }

            Console.WriteLine();
            Console.WriteLine("Quiz is completed!");
            Console.WriteLine("Your score is: " + score + "/3");
        }
    }
}

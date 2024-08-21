
using System;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("Welcome to the Quiz!");
            Console.WriteLine("Question 1: What is the capital of France?");
            Console.WriteLine("A. London");
            Console.WriteLine("B. Paris");
            Console.WriteLine("C. Berlin");
            Console.WriteLine("D. Madrid");
            Console.Write("Your answer: ");
            string answer1 = Console.ReadLine().ToUpper();
            if (answer1 == "B")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }

            Console.WriteLine("Question 2: What is the largest planet in our solar system?");
            Console.WriteLine("A. Mars");
            Console.WriteLine("B. Jupiter");
            Console.WriteLine("C. Earth");
            Console.WriteLine("D. Saturn");
            Console.Write("Your answer: ");
            string answer2 = Console.ReadLine().ToUpper();
            if (answer2 == "B")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }

            Console.WriteLine("Your final score is: " + score + "/2");

        }
    }
}

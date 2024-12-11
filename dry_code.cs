
using System;

namespace QuizSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("Welcome to the Quiz Simulator!");
            Console.WriteLine("Answer the following multiple-choice questions:");

            // Question 1
            Console.WriteLine("1. What is the capital of France?");
            Console.WriteLine("A. London");
            Console.WriteLine("B. Paris");
            Console.WriteLine("C. Rome");
            Console.WriteLine("D. Berlin");

            // Get user input
            Console.Write("Enter your answer (A, B, C, or D): ");
            string answer1 = Console.ReadLine().ToUpper();

            if (answer1 == "B")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect! The correct answer is B. Paris");
            }

            // Question 2
            Console.WriteLine("\n2. Who painted the Mona Lisa?");
            Console.WriteLine("A. Michelangelo");
            Console.WriteLine("B. Leonardo da Vinci");
            Console.WriteLine("C. Vincent van Gogh");
            Console.WriteLine("D. Pablo Picasso");

            // Get user input
            Console.Write("Enter your answer (A, B, C, or D): ");
            string answer2 = Console.ReadLine().ToUpper();

            if (answer2 == "B")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect! The correct answer is B. Leonardo da Vinci");
            }

            // Display final score
            Console.WriteLine($"\nYour final score is: {score}/2");

            Console.WriteLine("\nThank you for taking the quiz!");
        }
    }
}


using System;

namespace QuizSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("Welcome to the Basic Quiz!");
            Console.WriteLine();

            // Question 1
            Console.WriteLine("Question 1: What is the capital of France?");
            Console.WriteLine("A. London");
            Console.WriteLine("B. Paris");
            Console.WriteLine("C. Rome");
            Console.WriteLine("D. Madrid");

            Console.Write("Your answer: ");
            string answer1 = Console.ReadLine();

            if (answer1.ToUpper() == "B")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is B. Paris");
            }

            Console.WriteLine();

            // Question 2
            Console.WriteLine("Question 2: What is the largest planet in our solar system?");
            Console.WriteLine("A. Earth");
            Console.WriteLine("B. Mars");
            Console.WriteLine("C. Jupiter");
            Console.WriteLine("D. Saturn");

            Console.Write("Your answer: ");
            string answer2 = Console.ReadLine();

            if (answer2.ToUpper() == "C")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is C. Jupiter");
            }

            Console.WriteLine();

            // Question 3
            Console.WriteLine("Question 3: Who painted the Mona Lisa?");
            Console.WriteLine("A. Vincent van Gogh");
            Console.WriteLine("B. Leonardo da Vinci");
            Console.WriteLine("C. Pablo Picasso");
            Console.WriteLine("D. Michelangelo");

            Console.Write("Your answer: ");
            string answer3 = Console.ReadLine();

            if (answer3.ToUpper() == "B")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is B. Leonardo da Vinci");
            }

            Console.WriteLine();

            // Display final score
            Console.WriteLine("Quiz complete. You scored: " + score + "/3");

        }
    }
}

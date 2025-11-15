
using System;

namespace BasicQuizSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("Welcome to the Basic Quiz!");
            Console.WriteLine();

            Console.WriteLine("Question 1: What is the capital of France?");
            Console.WriteLine("A) London");
            Console.WriteLine("B) Berlin");
            Console.WriteLine("C) Paris");
            Console.WriteLine("D) Madrid");

            Console.Write("Your answer: ");
            string answer1 = Console.ReadLine().ToUpper();

            if (answer1 == "C")
            {
                score++;
            }

            Console.WriteLine();

            Console.WriteLine("Question 2: Who painted the Mona Lisa?");
            Console.WriteLine("A) Michelangelo");
            Console.WriteLine("B) Leonardo da Vinci");
            Console.WriteLine("C) Vincent van Gogh");
            Console.WriteLine("D) Pablo Picasso");

            Console.Write("Your answer: ");
            string answer2 = Console.ReadLine().ToUpper();

            if (answer2 == "B")
            {
                score++;
            }

            Console.WriteLine();

            Console.WriteLine("Question 3: Which planet is known as the Red Planet?");
            Console.WriteLine("A) Venus");
            Console.WriteLine("B) Earth");
            Console.WriteLine("C) Mars");
            Console.WriteLine("D) Jupiter");

            Console.Write("Your answer: ");
            string answer3 = Console.ReadLine().ToUpper();

            if (answer3 == "C")
            {
                score++;
            }

            Console.WriteLine();

            Console.WriteLine("Quiz complete! You scored: " + score + "/3");

            if(score == 3)
            {
                Console.WriteLine("Congratulations! You got all questions correct.");
            }
            else
            {
                Console.WriteLine("You can do better next time!");
            }
        }
    }
}

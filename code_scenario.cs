
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
            Console.WriteLine("A) London");
            Console.WriteLine("B) Paris");
            Console.WriteLine("C) Rome");

            string answer1 = Console.ReadLine();
            if (answer1.ToUpper() == "B")
            {
                score++;
            }

            Console.WriteLine("Question 2: What is the largest planet in our solar system?");
            Console.WriteLine("A) Earth");
            Console.WriteLine("B) Jupiter");
            Console.WriteLine("C) Mars");

            string answer2 = Console.ReadLine();
            if (answer2.ToUpper() == "B")
            {
                score++;
            }

            Console.WriteLine("Question 3: Who painted the Mona Lisa?");
            Console.WriteLine("A) Vincent van Gogh");
            Console.WriteLine("B) Leonardo da Vinci");
            Console.WriteLine("C) Pablo Picasso");

            string answer3 = Console.ReadLine();
            if (answer3.ToUpper() == "B")
            {
                score++;
            }

            Console.WriteLine("Quiz completed! You scored: " + score + " out of 3.");
        }
    }
}

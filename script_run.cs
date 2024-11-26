
using System;

namespace EducationalQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("Welcome to the Educational Quiz!");
            Console.WriteLine("Answer the following questions by typing the correct option (A, B, C, or D).\n");

            Console.WriteLine("Question 1: What is the capital of France?");
            Console.WriteLine("A. London");
            Console.WriteLine("B. Madrid");
            Console.WriteLine("C. Paris");
            Console.WriteLine("D. Berlin");

            string answer1 = Console.ReadLine();
            if (answer1.ToUpper() == "C")
            {
                score++;
            }

            Console.WriteLine("\nQuestion 2: What is the powerhouse of the cell?");
            Console.WriteLine("A. Nucleus");
            Console.WriteLine("B. Mitochondria");
            Console.WriteLine("C. Golgi Apparatus");
            Console.WriteLine("D. Endoplasmic Reticulum");

            string answer2 = Console.ReadLine();
            if (answer2.ToUpper() == "B")
            {
                score++;
            }

            Console.WriteLine("\nQuestion 3: What is the chemical symbol for Gold?");
            Console.WriteLine("A. Au");
            Console.WriteLine("B. Ag");
            Console.WriteLine("C. Fe");
            Console.WriteLine("D. Cu");

            string answer3 = Console.ReadLine();
            if (answer3.ToUpper() == "A")
            {
                score++;
            }

            Console.WriteLine($"\nQuiz Complete! Your score is: {score}/3");

            if(score == 3)
            {
                Console.WriteLine("Congratulations! You got all the correct answers!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
        }
    }
}

using System;

namespace PersonalityQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Personality Quiz!");
            Console.WriteLine("Please answer the following questions:\n");

            int scoreA = 0;
            int scoreB = 0;

            // Question 1
            Console.WriteLine("Q1: Do you prefer to work alone or with others?");
            Console.WriteLine("a) Alone");
            Console.WriteLine("b) With others");
            Console.Write("Your answer (a/b): ");
            string answer1 = Console.ReadLine()?.ToLower();

            if (answer1 == "a")
                scoreA++;
            else if (answer1 == "b")
                scoreB++;
            else
                Console.WriteLine("Invalid input, moving to the next question.");

            // Question 2
            Console.WriteLine("\nQ2: Do you consider yourself more of a thinker or a feeler?");
            Console.WriteLine("a) Thinker");
            Console.WriteLine("b) Feeler");
            Console.Write("Your answer (a/b): ");
            string answer2 = Console.ReadLine()?.ToLower();

            if (answer2 == "a")
                scoreA++;
            else if (answer2 == "b")
                scoreB++;
            else
                Console.WriteLine("Invalid input, moving to the next question.");

            // Question 3
            Console.WriteLine("\nQ3: Do you prefer structured routine or spontaneous adventure?");
            Console.WriteLine("a) Structured routine");
            Console.WriteLine("b) Spontaneous adventure");
            Console.Write("Your answer (a/b): ");
            string answer3 = Console.ReadLine()?.ToLower();

            if (answer3 == "a")
                scoreA++;
            else if (answer3 == "b")
                scoreB++;
            else
                Console.WriteLine("Invalid input, moving to the next question.");

            // Result
            Console.WriteLine("\nQuiz Results:");
            if (scoreA > scoreB)
            {
                Console.WriteLine("You are more of a Thinker and prefer structured routines!");
            }
            else if (scoreB > scoreA)
            {
                Console.WriteLine("You are more of a Feelers and enjoy spontaneous adventures!");
            }
            else
            {
                Console.WriteLine("You have a balanced personality! You enjoy both structured and spontaneous activities, and thinkers and feelers alike.");
            }
        }
    }
}
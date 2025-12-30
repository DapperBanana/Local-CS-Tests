using System;

namespace PersonalityQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Personality Quiz!");
            Console.WriteLine("Please answer the following questions:\n");

            int introvertScore = 0;
            int extrovertScore = 0;

            // Question 1
            Console.WriteLine("1. Do you prefer social gatherings or quiet evenings?");
            Console.WriteLine("a) Social gatherings");
            Console.WriteLine("b) Quiet evenings");
            Console.Write("Your answer (a/b): ");
            string answer1 = Console.ReadLine().ToLower();
            if (answer1 == "a")
                extrovertScore++;
            else if (answer1 == "b")
                introvertScore++;
            else
                Console.WriteLine("Invalid input, moving on.");

            // Question 2
            Console.WriteLine("\n2. Do you find energizing interactions with others?");
            Console.WriteLine("a) Yes");
            Console.WriteLine("b) No");
            Console.Write("Your answer (a/b): ");
            string answer2 = Console.ReadLine().ToLower();
            if (answer2 == "a")
                extrovertScore++;
            else if (answer2 == "b")
                introvertScore++;
            else
                Console.WriteLine("Invalid input, moving on.");

            // Question 3
            Console.WriteLine("\n3. Which do you prefer?");
            Console.WriteLine("a) Going out with friends");
            Console.WriteLine("b) Reading a book alone");
            Console.Write("Your answer (a/b): ");
            string answer3 = Console.ReadLine().ToLower();
            if (answer3 == "a")
                extrovertScore++;
            else if (answer3 == "b")
                introvertScore++;
            else
                Console.WriteLine("Invalid input, moving on.");

            // Final result
            Console.WriteLine("\nCalculating your personality type...\n");
            if (extrovertScore > introvertScore)
            {
                Console.WriteLine("You are more extroverted!");
            }
            else if (introvertScore > extrovertScore)
            {
                Console.WriteLine("You are more introverted!");
            }
            else
            {
                Console.WriteLine("You have a balanced personality!");
            }

            Console.WriteLine("\nThank you for taking the quiz!");
        }
    }
}
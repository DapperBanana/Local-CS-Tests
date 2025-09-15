
using System;

namespace PersonalityQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the personality quiz!");
            Console.WriteLine("Answer each question with the corresponding number (1-5)");

            int totalScore = 0;

            // Question 1
            Console.WriteLine("1. How adventurous are you?");
            Console.WriteLine("1 - Not adventurous at all");
            Console.WriteLine("2 - A little adventurous");
            Console.WriteLine("3 - Moderately adventurous");
            Console.WriteLine("4 - Very adventurous");
            Console.WriteLine("5 - Extremely adventurous");

            int response = GetResponse();
            totalScore += response;

            // Question 2
            Console.WriteLine("2. How organized are you?");
            Console.WriteLine("1 - Very disorganized");
            Console.WriteLine("2 - Somewhat disorganized");
            Console.WriteLine("3 - Moderately organized");
            Console.WriteLine("4 - Very organized");
            Console.WriteLine("5 - Extremely organized");

            response = GetResponse();
            totalScore += response;

            // Question 3
            Console.WriteLine("3. How outgoing are you?");
            Console.WriteLine("1 - Very introverted");
            Console.WriteLine("2 - Somewhat introverted");
            Console.WriteLine("3 - Balanced between introverted and extroverted");
            Console.WriteLine("4 - Somewhat extroverted");
            Console.WriteLine("5 - Very extroverted");

            response = GetResponse();
            totalScore += response;

            // Determine result
            if (totalScore >= 3 && totalScore <= 7)
            {
                Console.WriteLine("You are a reserved and cautious person.");
            }
            else if (totalScore >= 8 && totalScore <= 12)
            {
                Console.WriteLine("You are a balanced and adaptable person.");
            }
            else if (totalScore >= 13 && totalScore <= 15)
            {
                Console.WriteLine("You are an adventurous and outgoing person.");
            }
        }

        static int GetResponse()
        {
            int response;
            while (!int.TryParse(Console.ReadLine(), out response) || response < 1 || response > 5)
            {
                Console.WriteLine("Please enter a valid response (1-5)");
            }
            return response;
        }
    }
}

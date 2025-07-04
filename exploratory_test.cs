
using System;

namespace BasicQuizSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questions = {
                "What is the capital of France?",
                "What is the largest planet in our solar system?",
                "Who wrote Romeo and Juliet?"
            };

            string[] options = {
                "A. Paris \t B. London \t C. Berlin \t D. Madrid",
                "A. Mars \t B. Jupiter \t C. Earth \t D. Saturn",
                "A. William Shakespeare \t B. Jane Austen \t C. Charles Dickens \t D. F. Scott Fitzgerald"
            };

            string[] answers = { "A", "B", "A" };
            string[] userResponses = new string[questions.Length];

            Console.WriteLine("Welcome to the Basic Quiz!");
            Console.WriteLine("--------------------------------");

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                Console.WriteLine(options[i]);

                Console.Write("Enter your answer (A, B, C, or D): ");
                userResponses[i] = Console.ReadLine();
            }

            int score = 0;
            for (int i = 0; i < questions.Length; i++)
            {
                if (userResponses[i].ToUpper() == answers[i])
                {
                    score++;
                }
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Quiz Results:");
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}: {questions[i]}");
                Console.WriteLine($"Your answer: {userResponses[i]}");
                Console.WriteLine($"Correct answer: {answers[i]}");
                Console.WriteLine();
            }

            Console.WriteLine($"Your score: {score}/{questions.Length}");

            if (score == questions.Length)
            {
                Console.WriteLine("Congratulations! You got a perfect score!");
            }
        }
    }
}

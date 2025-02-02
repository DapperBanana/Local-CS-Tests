
using System;

class Program
{
    static void Main()
    {
        int score = 0;

        // Questions
        string[] questions = {
            "What is the capital of France?",
            "What is the largest planet in our solar system?",
            "Who wrote 'Romeo and Juliet'?",
        };

        // Choices
        string[][] choices = {
            new string[] { "A. London", "B. Paris", "C. Berlin", "D. Madrid" },
            new string[] { "A. Earth", "B. Jupiter", "C. Saturn", "D. Mars" },
            new string[] { "A. William Shakespeare", "B. Charles Dickens", "C. Jane Austen", "D. J.K. Rowling" }
        };

        // Correct answers
        string[] correctAnswers = { "B", "B", "A" };

        // Display questions and choices
        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine(questions[i]);
            foreach (string choice in choices[i])
            {
                Console.WriteLine(choice);
            }

            Console.Write("Your answer: ");
            string userAnswer = Console.ReadLine().ToUpper();

            if (userAnswer == correctAnswers[i])
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is: " + correctAnswers[i]);
            }
        }

        // Display final score
        Console.WriteLine("Quiz completed! Your score is: " + score + "/" + questions.Length);
    }
}

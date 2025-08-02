
using System;

class Program
{
    static void Main()
    {
        int score = 0;

        // Quiz questions and answers
        string[] questions = {"What is the capital of France?", "What is the largest planet in our solar system?", "Who wrote the play Romeo and Juliet?"};
        string[] options = {"A) London B) Paris C) Berlin", "A) Neptune B) Jupiter C) Mars", "A) William Shakespeare B) Jane Austen C) Charles Dickens"};
        string[] answers = {"B", "B", "A"};

        // Display and process each question
        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine(questions[i]);
            Console.WriteLine(options[i]);

            // Get user input
            Console.Write("Enter your answer: ");
            string userAnswer = Console.ReadLine().ToUpper();

            // Check if user's answer is correct
            if (userAnswer == answers[i])
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is: " + answers[i]);
            }

            Console.WriteLine();
        }

        // Display final score
        Console.WriteLine("Quiz complete. Your final score is: " + score + "/" + questions.Length);
    }
}

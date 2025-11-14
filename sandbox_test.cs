
using System;

class Program
{
    static void Main()
    {
        string[] questions = {
            "What is the capital of France?",
            "What is the largest mammal in the world?",
            "What is the color of the sky?"
        };

        string[] options = {
            "A. London\nB. Paris\nC. Berlin\nD. Rome",
            "A. Elephant\nB. Blue whale\nC. Lion\nD. Giraffe",
            "A. Green\nB. Blue\nC. Red\nD. Yellow"
        };

        string[] answers = {
            "B", // Paris
            "B", // Blue whale
            "B"  // Blue
        };

        int score = 0;

        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine(questions[i]);
            Console.WriteLine(options[i]);

            Console.Write("Enter your answer (A, B, C, or D): ");
            string userAnswer = Console.ReadLine().ToUpper();

            if (userAnswer == answers[i])
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is " + answers[i] + ".\n");
            }
        }

        Console.WriteLine("Quiz completed. You got " + score + " out of " + questions.Length + " questions correct.");
    }
}

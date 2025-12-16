using System;
using System.Collections.Generic;

class Quiz
{
    static void Main()
    {
        // List of questions
        var questions = new List<(string Question, string[] Options, int CorrectAnswer)>
        {
            ("What is the capital of France?", new string[] { "Berlin", "London", "Paris", "Madrid" }, 3),
            ("Which planet is known as the Red Planet?", new string[] { "Earth", "Mars", "Jupiter", "Saturn" }, 2),
            ("What is the largest ocean on Earth?", new string[] { "Atlantic Ocean", "Indian Ocean", "Arctic Ocean", "Pacific Ocean" }, 4),
        };

        int score = 0;
        int questionNumber = 1;

        Console.WriteLine("Welcome to the Basic Quiz!\n");

        foreach (var (Question, Options, CorrectAnswer) in questions)
        {
            Console.WriteLine($"Question {questionNumber}: {Question}");
            for (int i = 0; i < Options.Length; i++)
            {
                Console.WriteLine($"  {i + 1}. {Options[i]}");
            }

            int userAnswer = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write("Your answer (1-4): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out userAnswer) && userAnswer >= 1 && userAnswer <= Options.Length)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                }
            }

            if (userAnswer == CorrectAnswer)
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorrect. The correct answer was: {Options[CorrectAnswer - 1]}\n");
            }
            questionNumber++;
        }

        Console.WriteLine($"Quiz complete! Your score: {score} out of {questions.Count}");
    }
}
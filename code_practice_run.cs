
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> questions = new List<string> {
            "What is the capital of France?",
            "What is the largest planet in our solar system?",
            "Who wrote the novel 'To Kill a Mockingbird'?",
            "What is the chemical symbol for gold?"
        };

        List<List<string>> options = new List<List<string>> {
            new List<string> { "A. London", "B. Paris", "C. Rome", "D. Madrid" },
            new List<string> { "A. Saturn", "B. Jupiter", "C. Mars", "D. Earth" },
            new List<string> { "A. Ernest Hemingway", "B. F. Scott Fitzgerald", "C. Harper Lee", "D. J. D. Salinger" },
            new List<string> { "A. Go", "B. Gd", "C. Au", "D. Ag" }
        };

        List<int> correctAnswers = new List<int> { 1, 1, 2, 2 };

        int score = 0;

        for (int i = 0; i < questions.Count; i++)
        {
            Console.WriteLine(questions[i]);

            foreach (string option in options[i])
            {
                Console.WriteLine(option);
            }

            Console.Write("Enter your answer: ");
            int answer = int.Parse(Console.ReadLine());

            if (answer == correctAnswers[i])
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorrect. The correct answer is {options[i][correctAnswers[i] - 1]}\n");
            }
        }

        Console.WriteLine($"Quiz completed. You scored {score} out of {questions.Count}.\n");
    }
}

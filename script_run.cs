using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List of questions
        List<Question> questions = new List<Question>
        {
            new Question
            {
                Text = "What is the capital of France?",
                Options = new List<string> { "A) Berlin", "B) London", "C) Paris", "D) Madrid" },
                CorrectOption = 'C'
            },
            new Question
            {
                Text = "Which planet is known as the Red Planet?",
                Options = new List<string> { "A) Earth", "B) Mars", "C) Jupiter", "D) Saturn" },
                CorrectOption = 'B'
            },
            new Question
            {
                Text = "Who wrote 'Romeo and Juliet'?",
                Options = new List<string> { "A) Charles Dickens", "B) William Shakespeare", "C) Mark Twain", "D) Leo Tolstoy" },
                CorrectOption = 'B'
            }
        };

        int score = 0;

        Console.WriteLine("Welcome to the Quiz!\n");

        foreach (var question in questions)
        {
            Console.WriteLine(question.Text);
            foreach (var option in question.Options)
            {
                Console.WriteLine(option);
            }
            Console.Write("Your answer (A, B, C, D): ");
            char userAnswer = Char.ToUpper(Console.ReadLine()[0]);

            if (userAnswer == question.CorrectOption)
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer was {question.CorrectOption}.\n");
            }
        }

        Console.WriteLine($"Quiz complete! You scored {score} out of {questions.Count}.");
    }
}

class Question
{
    public string Text { get; set; }
    public List<string> Options { get; set; }
    public char CorrectOption { get; set; }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List of questions
        List<Question> questions = new List<Question>()
        {
            new Question
            {
                Text = "What is the capital of France?",
                Options = new List<string> { "A) Berlin", "B) Paris", "C) Madrid", "D) Rome" },
                CorrectOption = 'B'
            },
            new Question
            {
                Text = "Which planet is known as the Red Planet?",
                Options = new List<string> { "A) Earth", "B) Mars", "C) Jupiter", "D) Venus" },
                CorrectOption = 'B'
            },
            new Question
            {
                Text = "Who wrote 'Romeo and Juliet'?",
                Options = new List<string> { "A) William Shakespeare", "B) Mark Twain", "C) Charles Dickens", "D) Jane Austen" },
                CorrectOption = 'A'
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
            char userAnswer;
            while (true)
            {
                string input = Console.ReadLine().Trim().ToUpper();
                if (input.Length == 1 && "ABCD".Contains(input))
                {
                    userAnswer = input[0];
                    break;
                }
                else
                {
                    Console.Write("Invalid input. Please enter A, B, C, or D: ");
                }
            }

            if (userAnswer == question.CorrectOption)
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorrect. The correct answer was {question.CorrectOption}.\n");
            }
        }

        Console.WriteLine($"Quiz completed! Your score: {score} out of {questions.Count}");
    }
}

class Question
{
    public string Text { get; set; }
    public List<string> Options { get; set; }
    public char CorrectOption { get; set; }
}
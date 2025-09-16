
using System;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("Welcome to the Quiz!");
            Console.WriteLine("Choose the correct option for each question.");

            string[] questions = { "1. What is the capital of France?", 
                                    "2. Who is the author of 'Romeo and Juliet'?", 
                                    "3. Which planet is known as the Red Planet?" };

            string[] options = {"A. London\tB. Paris\tC. Rome\tD. Berlin",
                                "A. William Shakespeare\tB. Jane Austen\tC. Charles Dickens\tD. Leo Tolstoy",
                                "A. Venus\tB. Mars\tC. Jupiter\tD. Saturn"};

            string[] answers = { "B", "A", "B" };

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                Console.WriteLine(options[i]);
                
                Console.Write("Your answer: ");
                string userAnswer = Console.ReadLine().ToUpper();

                if (userAnswer == answers[i])
                {
                    Console.WriteLine("Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect! The correct answer is: " + answers[i] + "\n");
                }
            }

            Console.WriteLine("Quiz completed! Your score is: " + score + "/" + questions.Length);

            if(score == questions.Length)
            {
                Console.WriteLine("Congratulations! You got all the answers correct!");
            }
        }
    }
}

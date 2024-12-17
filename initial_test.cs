
using System;

namespace BasicQuizSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("Welcome to the Basic Quiz Simulator!");
            Console.WriteLine("Answer the following multiple-choice questions.\n");

            // Questions and Answers
            string[] questions = { "1. What is the capital city of France?", "2. How many continents are there in the world?", "3. Who wrote the play 'Romeo and Juliet'?" };
            string[] options = { "A. London    B. Paris    C. Madrid   D. New York", "A. 5    B. 6    C. 7   D. 8", "A. William Shakespeare    B. Jane Austen    C. Charles Dickens    D. F. Scott Fitzgerald" };
            string[] correctAnswers = { "B", "C", "A" };

            // Display questions and options
            for(int i=0; i<questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                Console.WriteLine(options[i]);

                Console.Write("Your answer: ");
                string userAnswer = Console.ReadLine().ToUpper();

                if(userAnswer == correctAnswers[i])
                {
                    Console.WriteLine("Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect!\n");
                }
            }

            Console.WriteLine("Quiz completed! Your score is: " + score + " out of " + questions.Length);

            if(score == questions.Length)
            {
                Console.WriteLine("Congratulations! You got a perfect score!");
            }
            else
            {
                Console.WriteLine("Study harder and try again next time!");
            }
        }
    }
}

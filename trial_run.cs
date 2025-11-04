
using System;

class Program
{
    static void Main()
    {
        int score = 0;

        // Define quiz questions and answers
        string[] questions = { "What is the capital of France?", "Who is the author of Harry Potter series?", "What is the largest planet in our solar system?" };
        string[] options = { "A. London\nB. Paris\nC. Rome", "A. J.R.R. Tolkien\nB. J.K. Rowling\nC. George R.R. Martin", "A. Venus\nB. Jupiter\nC. Saturn" };
        string[] answers = { "B", "B", "B" };

        Console.WriteLine("Welcome to the Quiz!");

        // Loop through each question
        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine($"\nQuestion {i + 1}: {questions[i]}");
            Console.WriteLine(options[i]);

            // Get user input
            Console.Write("Enter your answer (A, B, or C): ");
            string userAnswer = Console.ReadLine().ToUpper();

            // Check if the answer is correct
            if (userAnswer == answers[i])
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is: " + answers[i]);
            }
        }

        // Display final score
        Console.WriteLine($"\nQuiz completed! Your final score is: {score}/{questions.Length}");

        Console.ReadLine();
    }
}

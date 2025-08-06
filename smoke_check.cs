
using System;

class Program
{
    static void Main()
    {
        // Define quiz questions and answers
        string[] questions = { 
            "What is the capital of France?", 
            "Who wrote Romeo and Juliet?", 
            "What is the tallest mountain in the world?" 
        };
        
        string[] answers = { 
            "Paris", 
            "William Shakespeare", 
            "Mount Everest" 
        };
        
        int score = 0;

        // Display and check user's answers
        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine(questions[i]);
            string userAnswer = Console.ReadLine();
            
            if (userAnswer.ToLower() == answers[i].ToLower())
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is: " + answers[i] + "\n");
            }
        }

        // Display final score
        Console.WriteLine("Quiz complete! Your score is: " + score + "/" + questions.Length);
    }
}

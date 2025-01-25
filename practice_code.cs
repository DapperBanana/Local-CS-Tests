
using System;

class Program
{
    static void Main()
    {
        int score = 0;
        
        Console.WriteLine("=====================");
        Console.WriteLine("Welcome to the Quiz!");
        Console.WriteLine("=====================");
        
        Console.WriteLine("Question 1: What is the capital of France?");
        string answer1 = Console.ReadLine();
        if (answer1.ToLower() == "paris")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is Paris.");
        }
        
        Console.WriteLine("Question 2: What is the largest planet in our solar system?");
        string answer2 = Console.ReadLine();
        if (answer2.ToLower() == "jupiter")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is Jupiter.");
        }
        
        Console.WriteLine("Question 3: Who wrote the play 'Romeo and Juliet'?");
        string answer3 = Console.ReadLine();
        if (answer3.ToLower() == "shakespeare" || answer3.ToLower() == "william shakespeare")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is Shakespeare.");
        }
        
        Console.WriteLine("=====================");
        Console.WriteLine("Quiz completed!");
        Console.WriteLine("Your score is: " + score + " out of 3");
        Console.WriteLine("=====================");
    }
}

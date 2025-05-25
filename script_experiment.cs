
using System;

class Quiz
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Quiz!");
        
        // Question 1
        Console.WriteLine("Question 1: What is the capital of France?");
        Console.WriteLine("A) London");
        Console.WriteLine("B) Paris");
        Console.WriteLine("C) Madrid");
        string answer1 = Console.ReadLine();
        if(answer1.ToUpper() == "B")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect, the correct answer is B) Paris");
        }

        // Question 2
        Console.WriteLine("Question 2: What is the largest planet in our solar system?");
        Console.WriteLine("A) Earth");
        Console.WriteLine("B) Jupiter");
        Console.WriteLine("C) Saturn");
        string answer2 = Console.ReadLine();
        if(answer2.ToUpper() == "B")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect, the correct answer is B) Jupiter");
        }

        // Question 3
        Console.WriteLine("Question 3: Who wrote the play 'Romeo and Juliet'?");
        Console.WriteLine("A) William Shakespeare");
        Console.WriteLine("B) Jane Austen");
        Console.WriteLine("C) Charles Dickens");
        string answer3 = Console.ReadLine();
        if(answer3.ToUpper() == "A")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect, the correct answer is A) William Shakespeare");
        }

        Console.WriteLine($"Your final score is: {score} out of 3");

        if(score == 3)
        {
            Console.WriteLine("Congratulations, you got a perfect score!");
        }
        else if(score >= 2)
        {
            Console.WriteLine("Well done!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }
   }
}

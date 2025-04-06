
using System;

class Quiz
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Quiz!");
        Console.WriteLine("");

        // Question 1
        Console.WriteLine("Question 1: What is the capital of France?");
        Console.WriteLine("A. London");
        Console.WriteLine("B. Paris");
        Console.WriteLine("C. Rome");
        Console.WriteLine("D. Madrid");
        Console.Write("Your answer: ");
        string answer1 = Console.ReadLine();
        if (answer1.ToUpper() == "B")
        {
            score++;
        }

        // Question 2
        Console.WriteLine("");
        Console.WriteLine("Question 2: What is 2 + 2?");
        Console.WriteLine("A. 3");
        Console.WriteLine("B. 4");
        Console.WriteLine("C. 5");
        Console.WriteLine("D. 6");
        Console.Write("Your answer: ");
        string answer2 = Console.ReadLine();
        if (answer2.ToUpper() == "B")
        {
            score++;
        }

        // Question 3
        Console.WriteLine("");
        Console.WriteLine("Question 3: Who wrote 'Romeo and Juliet'?");
        Console.WriteLine("A. William Shakespeare");
        Console.WriteLine("B. Jane Austen");
        Console.WriteLine("C. Charles Dickens");
        Console.WriteLine("D. J.K. Rowling");
        Console.Write("Your answer: ");
        string answer3 = Console.ReadLine();
        if (answer3.ToUpper() == "A")
        {
            score++;
        }

        Console.WriteLine("");
        Console.WriteLine("Quiz Complete!");
        Console.WriteLine("Your score is: " + score + "/3");

        if (score == 3)
        {
            Console.WriteLine("Congratulations! You got a perfect score!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}

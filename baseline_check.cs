
using System;

class Quiz
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Quiz!");
        Console.WriteLine("Question 1: What is the capital of France?");
        Console.WriteLine("A. London");
        Console.WriteLine("B. Rome");
        Console.WriteLine("C. Paris");
        Console.WriteLine("D. Madrid");
        Console.Write("Your answer: ");
        string answer1 = Console.ReadLine();
        if (answer1.ToUpper() == "C")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

        Console.WriteLine("Question 2: What is the largest planet in our solar system?");
        Console.WriteLine("A. Venus");
        Console.WriteLine("B. Earth");
        Console.WriteLine("C. Jupiter");
        Console.WriteLine("D. Saturn");
        Console.Write("Your answer: ");
        string answer2 = Console.ReadLine();
        if (answer2.ToUpper() == "C")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

        Console.WriteLine("Question 3: Who wrote the play 'Romeo and Juliet'?");
        Console.WriteLine("A. William Shakespeare");
        Console.WriteLine("B. Jane Austen");
        Console.WriteLine("C. J.K. Rowling");
        Console.WriteLine("D. Charles Dickens");
        Console.Write("Your answer: ");
        string answer3 = Console.ReadLine();
        if (answer3.ToUpper() == "A")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

        Console.WriteLine("Your final score is: " + score + " out of 3");
    }
}

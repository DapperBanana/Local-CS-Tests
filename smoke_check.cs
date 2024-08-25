
using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Basic Quiz!");
        Console.WriteLine("Question 1: What is the capital of France?");
        Console.WriteLine("A. Madrid");
        Console.WriteLine("B. Paris");
        Console.WriteLine("C. Rome");
        Console.WriteLine("D. Berlin");
        Console.Write("Your answer: ");
        string answer1 = Console.ReadLine();
        if (answer1.ToUpper() == "B")
        {
            score++;
        }

        Console.WriteLine("Question 2: What is the largest mammal in the world?");
        Console.WriteLine("A. Elephant");
        Console.WriteLine("B. Blue whale");
        Console.WriteLine("C. Giraffe");
        Console.WriteLine("D. Lion");
        Console.Write("Your answer: ");
        string answer2 = Console.ReadLine();
        if (answer2.ToUpper() == "B")
        {
            score++;
        }

        Console.WriteLine("Question 3: Who wrote the play 'Romeo and Juliet'?");
        Console.WriteLine("A. William Shakespeare");
        Console.WriteLine("B. Charles Dickens");
        Console.WriteLine("C. Jane Austen");
        Console.WriteLine("D. Mark Twain");
        Console.Write("Your answer: ");
        string answer3 = Console.ReadLine();
        if (answer3.ToUpper() == "A")
        {
            score++;
        }

        Console.WriteLine("Quiz completed! Your score is: " + score + "/3");

        Console.ReadLine();
    }
}


using System;

class Program
{
    static void Main()
    {
        int score = 0;
        
        Console.WriteLine("Welcome to the Basic Quiz!");
        Console.WriteLine("Question 1: What is the capital of France?");
        Console.WriteLine("A) London");
        Console.WriteLine("B) Paris");
        Console.WriteLine("C) Rome");
        Console.WriteLine("D) Berlin");
        Console.Write("Your answer: ");
        string answer1 = Console.ReadLine().ToUpper();
        if(answer1 == "B")
        {
            score++;
        }
        
        Console.WriteLine("Question 2: What is the largest planet in our solar system?");
        Console.WriteLine("A) Earth");
        Console.WriteLine("B) Jupiter");
        Console.WriteLine("C) Saturn");
        Console.WriteLine("D) Mars");
        Console.Write("Your answer: ");
        string answer2 = Console.ReadLine().ToUpper();
        if(answer2 == "B")
        {
            score++;
        }
        
        Console.WriteLine("Question 3: Who wrote 'Romeo and Juliet'?");
        Console.WriteLine("A) William Shakespeare");
        Console.WriteLine("B) Charles Dickens");
        Console.WriteLine("C) Jane Austen");
        Console.WriteLine("D) Mark Twain");
        Console.Write("Your answer: ");
        string answer3 = Console.ReadLine().ToUpper();
        if(answer3 == "A")
        {
            score++;
        }
        
        Console.WriteLine("Quiz complete! You scored: " + score + " out of 3.");
    }
}

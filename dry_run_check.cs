
using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Basic Quiz!");
        Console.WriteLine("---------------------------");

        // Question 1
        Console.WriteLine("1. What is the capital of France?");
        Console.WriteLine("a) London");
        Console.WriteLine("b) Paris");
        Console.WriteLine("c) Rome");
        Console.WriteLine("d) Berlin");

        Console.Write("Your answer: ");
        string answer1 = Console.ReadLine();

        if (answer1.ToLower() == "b")
        {
            score++;
        }

        // Question 2
        Console.WriteLine("\n2. What is the largest mammal on Earth?");
        Console.WriteLine("a) Elephant");
        Console.WriteLine("b) Blue Whale");
        Console.WriteLine("c) Giraffe");
        Console.WriteLine("d) Dolphin");

        Console.Write("Your answer: ");
        string answer2 = Console.ReadLine();

        if (answer2.ToLower() == "b")
        {
            score++;
        }

        // Question 3
        Console.WriteLine("\n3. Who painted the Mona Lisa?");
        Console.WriteLine("a) Leonardo da Vinci");
        Console.WriteLine("b) Vincent van Gogh");
        Console.WriteLine("c) Pablo Picasso");
        Console.WriteLine("d) Michelangelo");

        Console.Write("Your answer: ");
        string answer3 = Console.ReadLine();

        if (answer3.ToLower() == "a")
        {
            score++;
        }

        Console.WriteLine("\nQuiz Completed! You got " + score + " out of 3 questions correct.");

        if (score == 3)
        {
            Console.WriteLine("Congratulations! You got a perfect score!");
        }
    }
}

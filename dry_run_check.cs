
using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Basic Quiz!");
        Console.WriteLine("Answer the following questions by entering the letter of the correct choice.");
        Console.WriteLine();

        // Question 1
        Console.WriteLine("1. What is the capital of France?");
        Console.WriteLine("A) London");
        Console.WriteLine("B) Paris");
        Console.WriteLine("C) Berlin");
        Console.WriteLine("D) Rome");

        string answer1 = Console.ReadLine().ToUpper();
        if (answer1 == "B")
        {
            score++;
        }

        // Question 2
        Console.WriteLine();
        Console.WriteLine("2. Who painted the Mona Lisa?");
        Console.WriteLine("A) Leonardo da Vinci");
        Console.WriteLine("B) Pablo Picasso");
        Console.WriteLine("C) Vincent van Gogh");
        Console.WriteLine("D) Jackson Pollock");

        string answer2 = Console.ReadLine().ToUpper();
        if (answer2 == "A")
        {
            score++;
        }

        // Question 3
        Console.WriteLine();
        Console.WriteLine("3. What is the largest planet in our solar system?");
        Console.WriteLine("A) Venus");
        Console.WriteLine("B) Earth");
        Console.WriteLine("C) Jupiter");
        Console.WriteLine("D) Mars");

        string answer3 = Console.ReadLine().ToUpper();
        if (answer3 == "C")
        {
            score++;
        }

        Console.WriteLine();
        Console.WriteLine("Quiz completed!");
        Console.WriteLine("Your score is: " + score + " out of 3");

        if (score == 3)
        {
            Console.WriteLine("Congratulations! You got a perfect score!");
        }
    }
}

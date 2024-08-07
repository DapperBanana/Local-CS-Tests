
using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Educational Quiz!");
        Console.WriteLine("Answer the following questions to test your knowledge.");

        // Question 1
        Console.WriteLine("\nQuestion 1: What is the capital of France?");
        Console.WriteLine("A) London");
        Console.WriteLine("B) Paris");
        Console.WriteLine("C) Madrid");
        string answer1 = Console.ReadLine();
        if (answer1.ToUpper() == "B")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is B) Paris.");
        }

        // Question 2
        Console.WriteLine("\nQuestion 2: What is the largest mammal on Earth?");
        Console.WriteLine("A) Elephant");
        Console.WriteLine("B) Blue whale");
        Console.WriteLine("C) Giraffe");
        string answer2 = Console.ReadLine();
        if (answer2.ToUpper() == "B")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is B) Blue whale.");
        }

        // Question 3
        Console.WriteLine("\nQuestion 3: Who painted the Mona Lisa?");
        Console.WriteLine("A) Leonardo da Vinci");
        Console.WriteLine("B) Vincent van Gogh");
        Console.WriteLine("C) Pablo Picasso");
        string answer3 = Console.ReadLine();
        if (answer3.ToUpper() == "A")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is A) Leonardo da Vinci.");
        }

        // Display score
        Console.WriteLine($"\nYou got {score} out of 3 questions correct.");

        // Check if user passed the quiz
        if (score >= 2)
        {
            Console.WriteLine("Congratulations! You passed the quiz.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the quiz. Better luck next time!");
        }
    }
}

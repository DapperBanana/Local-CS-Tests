
using System;

class QuizProgram
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Basic Quiz Program!");
        Console.WriteLine();

        // Question 1
        Console.WriteLine("1. What is the capital of France?");
        Console.WriteLine("A. London");
        Console.WriteLine("B. Paris");
        Console.WriteLine("C. Berlin");
        Console.WriteLine("D. Rome");

        string answer1 = Console.ReadLine();
        if (answer1.ToUpper() == "B")
        {
            score++;
        }

        // Question 2
        Console.WriteLine("2. Which planet is known as the 'Red Planet'?");
        Console.WriteLine("A. Earth");
        Console.WriteLine("B. Mars");
        Console.WriteLine("C. Venus");
        Console.WriteLine("D. Saturn");

        string answer2 = Console.ReadLine();
        if (answer2.ToUpper() == "B")
        {
            score++;
        }

        // Question 3
        Console.WriteLine("3. Who painted the Mona Lisa?");
        Console.WriteLine("A. Michelangelo");
        Console.WriteLine("B. Leonardo da Vinci");
        Console.WriteLine("C. Pablo Picasso");
        Console.WriteLine("D. Vincent van Gogh");

        string answer3 = Console.ReadLine();
        if (answer3.ToUpper() == "B")
        {
            score++;
        }

        // Display final score
        Console.WriteLine();
        Console.WriteLine("Quiz completed! Your final score is: " + score + "/3");
    }
}


using System;

class Quiz
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the educational quiz!");
        Console.WriteLine("Answer the following questions by typing the correct option (a, b, c, d).\n");

        // Question 1
        Console.WriteLine("1. What is the capital of France?");
        Console.WriteLine("a) Paris");
        Console.WriteLine("b) London");
        Console.WriteLine("c) Berlin");
        Console.WriteLine("d) Madrid");
        string answer1 = Console.ReadLine().ToLower();
        if (answer1 == "a")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is Paris.");
        }

        // Question 2
        Console.WriteLine("\n2. Which planet is known as the Red Planet?");
        Console.WriteLine("a) Venus");
        Console.WriteLine("b) Mercury");
        Console.WriteLine("c) Mars");
        Console.WriteLine("d) Jupiter");
        string answer2 = Console.ReadLine().ToLower();
        if (answer2 == "c")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is Mars.");
        }

        // Question 3
        Console.WriteLine("\n3. Who wrote the play 'Romeo and Juliet'?");
        Console.WriteLine("a) William Shakespeare");
        Console.WriteLine("b) Jane Austen");
        Console.WriteLine("c) Charles Dickens");
        Console.WriteLine("d) Mark Twain");
        string answer3 = Console.ReadLine().ToLower();
        if (answer3 == "a")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is William Shakespeare.");
        }

        Console.WriteLine($"\nQuiz completed!\nYour score is: {score}/3");

        if (score >= 2)
        {
            Console.WriteLine("Well done, you passed the quiz!");
        }
        else
        {
            Console.WriteLine("You did not pass the quiz. Better luck next time!");
        }
    }
}

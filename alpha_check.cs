
using System;

class PersonalityQuiz
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the Personality Quiz!");
        Console.WriteLine("Answer the following questions with 'A', 'B', 'C', or 'D'.");

        // Question 1
        Console.WriteLine("1. What is your favorite color?");
        Console.WriteLine("A. Red");
        Console.WriteLine("B. Blue");
        Console.WriteLine("C. Green");
        Console.WriteLine("D. Purple");
        char answer1 = char.ToUpper(Console.ReadKey().KeyChar);
        if (answer1 == 'A') score += 2;
        else if (answer1 == 'B') score += 4;
        else if (answer1 == 'C') score += 3;
        else if (answer1 == 'D') score += 1;

        // Question 2
        Console.WriteLine("\n2. What is your favorite season?");
        Console.WriteLine("A. Winter");
        Console.WriteLine("B. Spring");
        Console.WriteLine("C. Summer");
        Console.WriteLine("D. Fall");
        char answer2 = char.ToUpper(Console.ReadKey().KeyChar);
        if (answer2 == 'A') score += 1;
        else if (answer2 == 'B') score += 3;
        else if (answer2 == 'C') score += 4;
        else if (answer2 == 'D') score += 2;

        // Question 3
        Console.WriteLine("\n3. What is your favorite food?");
        Console.WriteLine("A. Pizza");
        Console.WriteLine("B. Salad");
        Console.WriteLine("C. Steak");
        Console.WriteLine("D. Sushi");
        char answer3 = char.ToUpper(Console.ReadKey().KeyChar);
        if (answer3 == 'A') score += 2;
        else if (answer3 == 'B') score += 3;
        else if (answer3 == 'C') score += 4;
        else if (answer3 == 'D') score += 1;

        // Determine result
        if (score >= 10 && score <= 12)
            Console.WriteLine("\nYou are an extrovert!");
        else if (score >= 13 && score <= 15)
            Console.WriteLine("\nYou are introverted but sociable!");
        else if (score >= 16 && score <= 18)
            Console.WriteLine("\nYou are balanced and easy-going!");
        else
            Console.WriteLine("\nYou are unique and independent!");

        Console.ReadLine();
    }
}

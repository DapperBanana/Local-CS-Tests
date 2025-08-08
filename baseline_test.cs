
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Movie Recommendation System!");

        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 13)
        {
            Console.WriteLine("We recommend you watch animated movies.");
        }
        else if (age < 18)
        {
            Console.WriteLine("We recommend you watch teen movies.");
        }
        else
        {
            Console.WriteLine("We recommend you watch action or drama movies.");
        }

        Console.WriteLine("Thank you for using our system. Enjoy your movie!");
    }
}

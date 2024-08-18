
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Space Exploration Game!");
        Console.WriteLine("You are the captain of a spaceship and your mission is to explore the galaxy.");

        Console.WriteLine("Choose your destination:");
        Console.WriteLine("1. Planet Alpha");
        Console.WriteLine("2. Nebula Theta");
        Console.WriteLine("3. Black Hole Omega");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You have arrived at Planet Alpha. It is a beautiful planet with lush forests and exotic wildlife.");
                break;
            case 2:
                Console.WriteLine("You have entered Nebula Theta. It is filled with colorful gases and mysterious energy fields.");
                break;
            case 3:
                Console.WriteLine("You are approaching Black Hole Omega. Proceed with caution!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

        Console.WriteLine("Thank you for playing the Space Exploration Game!");
    }
}


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Space Exploration Game!");

        Console.WriteLine("You are the captain of a spaceship and have the following options:");
        Console.WriteLine("1. Explore a nearby planet");
        Console.WriteLine("2. Travel to a different star system");
        Console.WriteLine("3. Return to Earth");

        int choice = 0;
        while (choice != 3)
        {
            Console.Write("Enter your choice (1, 2, 3): ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ExplorePlanet();
                    break;
                case 2:
                    TravelToStarSystem();
                    break;
                case 3:
                    Console.WriteLine("Returning to Earth. Game over.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ExplorePlanet()
    {
        Console.WriteLine("You have landed on a nearby planet and found valuable resources.");
    }

    static void TravelToStarSystem()
    {
        Console.WriteLine("You have traveled to a different star system and encountered hostile aliens.");
    }
}

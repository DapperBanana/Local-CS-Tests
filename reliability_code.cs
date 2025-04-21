
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Space Exploration Game!");

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Explore a new planet");
            Console.WriteLine("2. Travel to a new galaxy");
            Console.WriteLine("3. Quit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ExplorePlanet();
                    break;

                case 2:
                    TravelGalaxy();
                    break;

                case 3:
                    Console.WriteLine("Thanks for playing!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void ExplorePlanet()
    {
        Console.WriteLine("You have discovered a new planet!");
        Console.WriteLine("Do you want to land on it? (y/n)");

        string input = Console.ReadLine();

        if (input.ToLower() == "y")
        {
            Console.WriteLine("You have landed on the planet and found valuable resources.");
        }
        else
        {
            Console.WriteLine("You have decided not to land on the planet.");
        }
    }

    static void TravelGalaxy()
    {
        Console.WriteLine("You are now traveling to a new galaxy...");
        Console.WriteLine("You have encountered a wormhole that leads to a different dimension!");

        Random rand = new Random();
        int chance = rand.Next(1, 11);

        if (chance <= 5)
        {
            Console.WriteLine("You have successfully traveled to the new galaxy.");
        }
        else
        {
            Console.WriteLine("You got lost in space and can't find your way back.");
        }
    }
}


using System;
using System.Threading;

class SpaceExplorer
{
    static void Main()
    {
        Console.WriteLine("Welcome, Space Explorer!");

        while (true)
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Explore a new planet");
            Console.WriteLine("2. Refuel your spaceship");
            Console.WriteLine("3. Exit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ExplorePlanet();
                    break;
                case "2":
                    RefuelSpaceship();
                    break;
                case "3":
                    Console.WriteLine("Goodbye, Space Explorer!");
                    return;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
    }

    static void ExplorePlanet()
    {
        Console.WriteLine("Exploring a new planet...");

        // Simulating exploration process
        Console.WriteLine("Landing on the planet...");
        Thread.Sleep(2000);

        Random rnd = new Random();
        int result = rnd.Next(1, 4);

        if (result == 1)
        {
            Console.WriteLine("You have discovered a new species!");
        }
        else if (result == 2)
        {
            Console.WriteLine("You have found valuable resources!");
        }
        else
        {
            Console.WriteLine("Nothing of interest found.");
        }
    }

    static void RefuelSpaceship()
    {
        Console.WriteLine("Refueling your spaceship...");

        // Simulating refueling process
        Console.WriteLine("Refueling complete.");
    }
}

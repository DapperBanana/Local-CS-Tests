
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Space Exploration Game!");
        Console.WriteLine("You are in your spaceship and ready to explore the galaxy.");

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Visit a new planet");
            Console.WriteLine("2. Refuel your spaceship");
            Console.WriteLine("3. Exit the game");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    VisitPlanet();
                    break;
                case 2:
                    RefuelSpaceship();
                    break;
                case 3:
                    Console.WriteLine("Thanks for playing! Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void VisitPlanet()
    {
        Random random = new Random();
        string[] planets = { "Mars", "Jupiter", "Saturn", "Neptune", "Mercury" };

        int index = random.Next(planets.Length);
        string planet = planets[index];

        Console.WriteLine($"You are now visiting {planet}.");
        Console.WriteLine("Exploring the surface...");
        Console.WriteLine($"You found some interesting minerals on {planet}.");
    }

    static void RefuelSpaceship()
    {
        Console.WriteLine("Refueling your spaceship...");
        Console.WriteLine("Spaceship refueled successfully!");
    }
}

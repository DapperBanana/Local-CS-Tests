
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Space Explorer!");
        Console.WriteLine("You are aboard a spaceship embarking on a mission to explore the galaxy.");

        int totalPlanets = 10;
        int currentPlanet = 1;

        while (currentPlanet <= totalPlanets)
        {
            Console.WriteLine($"You have arrived at Planet {currentPlanet}.");
            Console.WriteLine("Do you want to land on this planet? (y/n)");
            string input = Console.ReadLine();

            if (input.ToLower() == "y")
            {
                ExplorePlanet();
            }

            currentPlanet++;
        }

        Console.WriteLine("You have explored all the planets in the galaxy. Mission complete!");
    }

    static void ExplorePlanet()
    {
        Console.WriteLine("Exploring the planet...");
        // Add more exploration tasks here
    }
}

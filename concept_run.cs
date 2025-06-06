
using System;

class SpaceExplorationGame
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Space Exploration Game!");

        int fuel = 100;
        int distanceTraveled = 0;

        while (fuel > 0)
        {
            Console.WriteLine("\nYou have " + fuel + " fuel left. Enter a command (travel, refuel, quit):");
            string command = Console.ReadLine();

            switch (command)
            {
                case "travel":
                    int distance = new Random().Next(1, 11);
                    Console.WriteLine("Traveling " + distance + " light years...");
                    fuel -= distance;
                    distanceTraveled += distance;
                    Console.WriteLine("You have traveled a total of " + distanceTraveled + " light years.");
                    break;
                case "refuel":
                    fuel = 100;
                    Console.WriteLine("Fuel refilled to 100%.");
                    break;
                case "quit":
                    Console.WriteLine("Quitting game...");
                    return;
                default:
                    Console.WriteLine("Invalid command. Please try again.");
                    break;
            }

            if (fuel <= 0)
            {
                Console.WriteLine("You have run out of fuel. Game over!");
            }
        }
    }
}

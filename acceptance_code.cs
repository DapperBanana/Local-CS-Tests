using System;

class SpaceExplorationGame
{
    static void Main()
    {
        Console.WriteLine("Welcome to Space Explorer!");
        Console.WriteLine("Your mission is to explore planets and gather resources.\n");

        int shipHealth = 100;
        int resources = 0;
        bool gameOver = false;

        while (!gameOver)
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Explore a new planet");
            Console.WriteLine("2. Check status");
            Console.WriteLine("3. Return to Earth and end mission");
            Console.Write("Enter choice (1-3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ExplorePlanet(ref shipHealth, ref resources);
                    if (shipHealth <= 0)
                    {
                        Console.WriteLine("Your ship has been destroyed! Game over.");
                        gameOver = true;
                    }
                    break;
                case "2":
                    Console.WriteLine($"Ship health: {shipHealth}");
                    Console.WriteLine($"Resources collected: {resources}\n");
                    break;
                case "3":
                    Console.WriteLine("Returning to Earth...");
                    Console.WriteLine($"Mission ended. Total resources collected: {resources}");
                    gameOver = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }
        }

        Console.WriteLine("Thank you for playing Space Explorer!");
    }

    static void ExplorePlanet(ref int health, ref int resources)
    {
        Random rnd = new Random();

        Console.WriteLine("\nExploring a new planet...");
        int encounter = rnd.Next(1, 4); // 1 to 3

        if (encounter == 1)
        {
            // Find resources
            int foundResources = rnd.Next(10, 51);
            resources += foundResources;
            Console.WriteLine($"Success! You found {foundResources} units of resources.\n");
        }
        else if (encounter == 2)
        {
            // Encounter hazards
            int damage = rnd.Next(10, 31);
            health -= damage;
            Console.WriteLine($"Hazard encountered! Your ship takes {damage} damage.\n");
        }
        else
        {
            // Empty planet
            Console.WriteLine("Nothing found on this planet.\n");
        }
    }
}
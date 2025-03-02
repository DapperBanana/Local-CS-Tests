
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Space Explorer game!");
        Console.WriteLine("You are on a mission to explore the galaxy.");

        bool gameOver = false;
        int shipFuel = 100;
        int shipHealth = 100;

        while (!gameOver)
        {
            Console.WriteLine("Options:");
            Console.WriteLine("1. Explore a planet");
            Console.WriteLine("2. Refuel your ship");
            Console.WriteLine("3. Exit game");

            Console.Write("Enter your choice: ");
            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ExplorePlanet(ref shipFuel, ref shipHealth);
                    break;
                case 2:
                    RefuelShip(ref shipFuel);
                    break;
                case 3:
                    gameOver = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (shipHealth <= 0 || shipFuel <= 0)
            {
                Console.WriteLine("Your ship has been destroyed. Game over!");
                gameOver = true;
            }
        }
    }

    static void ExplorePlanet(ref int fuel, ref int health)
    {
        Random rand = new Random();
        int fuelCost = rand.Next(10, 30);
        int healthLost = rand.Next(10, 30);

        Console.WriteLine($"Exploring planet... Fuel cost: {fuelCost}, Health lost: {healthLost}");

        fuel -= fuelCost;
        health -= healthLost;
    }

    static void RefuelShip(ref int fuel)
    {
        Random rand = new Random();
        int fuelGained = rand.Next(30, 50);

        Console.WriteLine($"Refueling ship... Fuel gained: {fuelGained}");

        fuel += fuelGained;
        if (fuel > 100)
        {
            fuel = 100;
        }
    }
}

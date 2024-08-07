
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Space Exploration Game!");

        int fuel = 100;
        int distanceTraveled = 0;
        int planetsVisited = 0;

        while (fuel > 0)
        {
            Console.WriteLine("\nYou have " + fuel + " units of fuel. Choose an option:");
            Console.WriteLine("1. Travel to a new planet");
            Console.WriteLine("2. Refuel your spaceship");
            Console.WriteLine("3. Exit the game");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Random random = new Random();
                int fuelUsed = random.Next(1, 11);
                fuel -= fuelUsed;

                if (fuel < 0)
                {
                    Console.WriteLine("You don't have enough fuel to travel. Game over!");
                    break;
                }

                distanceTraveled += random.Next(10, 101);
                planetsVisited++;

                Console.WriteLine("You traveled " + distanceTraveled + " light years and used " + fuelUsed + " units of fuel.");
            }
            else if (choice == 2)
            {
                fuel = 100;
                Console.WriteLine("You refueled your spaceship.");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Thanks for playing! You visited " + planetsVisited + " planets.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}

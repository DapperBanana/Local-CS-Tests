
using System;

namespace SpaceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int fuel = 100;
            int distanceTraveled = 0;

            Console.WriteLine("Welcome to the Space Game!");

            while (health > 0 && fuel > 0)
            {
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Travel to a new planet");
                Console.WriteLine("2. Refuel your spaceship");
                Console.WriteLine("3. Exit");

                int choice = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        Random random = new Random();
                        int distance = random.Next(1, 11);
                        Console.WriteLine("Traveling to a new planet...");
                        Console.WriteLine("You traveled " + distance + " light years.");
                        distanceTraveled += distance;
                        health -= distance * 2;
                        fuel -= distance * 3;
                        break;

                    case 2:
                        fuel = 100;
                        Console.WriteLine("Refueled spaceship to 100% fuel.");
                        break;

                    case 3:
                        Console.WriteLine("Exiting the game...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                if (health <= 0)
                {
                    Console.WriteLine("Your spaceship was destroyed! Game over.");
                }
                else if (fuel <= 0)
                {
                    Console.WriteLine("Your spaceship ran out of fuel! Game over.");
                }

                Console.WriteLine("Health: " + health);
                Console.WriteLine("Fuel: " + fuel);
                Console.WriteLine("Distance traveled: " + distanceTraveled + " light years");
                Console.WriteLine();
            }
        }
    }
}

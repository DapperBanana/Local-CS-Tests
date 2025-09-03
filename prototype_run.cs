
using System;

namespace SpaceshipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int fuel = 100;
            int distance = 0;

            Console.WriteLine("Welcome to the Spaceship Game!");
            Console.WriteLine("Your spaceship is ready for launch.");

            while (true)
            {
                Console.WriteLine("\nCurrent fuel level: " + fuel);
                Console.WriteLine("Current distance from earth: " + distance + " light years");

                Console.WriteLine("\nEnter a command:");
                Console.WriteLine("1. Fly to a new planet");
                Console.WriteLine("2. Refuel the spaceship");
                Console.WriteLine("3. Exit the game");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    int randomDistance = new Random().Next(1, 11);
                    fuel -= randomDistance * 2;
                    distance += randomDistance;

                    Console.WriteLine("Travelling " + randomDistance + " light years...");
                    if (fuel < 0)
                    {
                        Console.WriteLine("Out of fuel! Game over.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You have arrived at a new planet!");
                    }
                }
                else if (choice == 2)
                {
                    fuel = 100;
                    Console.WriteLine("Spaceship refuelled!");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Exiting game...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
}

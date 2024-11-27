
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

            while (true)
            {
                Console.WriteLine("\nYour spaceship stats:");
                Console.WriteLine("Fuel: " + fuel);
                Console.WriteLine("Distance traveled: " + distance);

                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1. Travel to a new planet");
                Console.WriteLine("2. Refuel the spaceship");
                Console.WriteLine("3. Quit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (fuel >= 10)
                        {
                            fuel -= 10;
                            distance += 20;
                            Console.WriteLine("\nYou have traveled to a new planet!");
                        }
                        else
                        {
                            Console.WriteLine("\nNot enough fuel to travel. Refuel the spaceship.");
                        }
                        break;
                    case 2:
                        fuel = 100;
                        Console.WriteLine("\nThe spaceship has been refueled.");
                        break;
                    case 3:
                        Console.WriteLine("\nThanks for playing!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}

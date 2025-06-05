
using System;

namespace SpaceExplorationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Space Exploration Game!");

            int fuel = 100;
            int distance = 0;

            while (true)
            {
                Console.WriteLine($"Current Fuel: {fuel}");
                Console.WriteLine($"Current Distance: {distance}");

                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Travel to a new planet");
                Console.WriteLine("2. Refuel at space station");
                Console.WriteLine("3. Quit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    if (fuel >= 50)
                    {
                        fuel -= 50;
                        distance += 10;
                        Console.WriteLine("Traveled to a new planet!");
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to travel!");
                    }
                }
                else if (choice == 2)
                {
                    fuel = 100;
                    Console.WriteLine("Refueled at space station!");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Exiting game...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                }

                if (distance >= 100)
                {
                    Console.WriteLine("Congratulations, you have completed the mission!");
                    break;
                }
            }
        }
    }
}

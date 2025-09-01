
using System;

namespace TextBasedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Space Adventure!");
            Console.WriteLine("You are the captain of a spaceship on a mission to explore new planets.");
            Console.WriteLine("You must make decisions to navigate through space safely and complete your mission.");

            int fuel = 100;
            int planetsVisited = 0;

            while (true)
            {
                Console.WriteLine($"Current Fuel: {fuel}%");
                Console.WriteLine($"Planets Visited: {planetsVisited}");

                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Refuel spaceship");
                Console.WriteLine("2. Visit a new planet");
                Console.WriteLine("3. Quit game");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    fuel = 100;
                    Console.WriteLine("Spaceship refueled to 100%");
                }
                else if (choice == 2)
                {
                    fuel -= 10;
                    planetsVisited++;
                    Console.WriteLine("Visited a new planet!");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Thank you for playing Space Adventure!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

                if (fuel <= 0)
                {
                    Console.WriteLine("Spaceship ran out of fuel. Game Over!");
                    break;
                }
            }
        }
    }
}

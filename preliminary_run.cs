
using System;

namespace SpaceExplorationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Space Exploration Game!");
            Console.WriteLine("You are a space explorer on a mission to discover new planets.");

            while (true)
            {
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Explore a new planet");
                Console.WriteLine("2. Refuel your spaceship");
                Console.WriteLine("3. Quit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ExplorePlanet();
                        break;
                    case 2:
                        RefuelSpaceship();
                        break;
                    case 3:
                        Console.WriteLine("Thank you for playing! Goodbye.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void ExplorePlanet()
        {
            Console.WriteLine("You have discovered a new planet!");
            Console.WriteLine("Do you want to land and explore it? (y/n)");

            string decision = Console.ReadLine();

            if (decision.ToLower() == "y")
            {
                Console.WriteLine("You landed on the planet and found valuable resources.");
            }
            else
            {
                Console.WriteLine("You decided not to land and continue your exploration.");
            }
        }

        static void RefuelSpaceship()
        {
            Console.WriteLine("Your spaceship has been refueled!");
        }
    }
}

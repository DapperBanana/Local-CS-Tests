
using System;

namespace SpaceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Space Explorer!");

            Console.WriteLine("You are currently onboard a spaceship and ready to explore the vastness of space.");

            Console.WriteLine("You have the following options:");
            Console.WriteLine("1. Explore a planet");
            Console.WriteLine("2. Travel to another star system");
            Console.WriteLine("3. Check your resources");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ExplorePlanet();
                    break;
                case "2":
                    TravelToStarSystem();
                    break;
                case "3":
                    CheckResources();
                    break;
                case "4":
                    QuitGame();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void ExplorePlanet()
        {
            Console.WriteLine("You land on a mysterious planet and discover strange alien creatures.");
            Console.WriteLine("You must collect resources to survive and continue your journey.");
            Console.WriteLine("Do you want to:");
            Console.WriteLine("1. Hunt for resources");
            Console.WriteLine("2. Communicate with the aliens");
            Console.WriteLine("3. Return to your spaceship");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("You hunt for resources and find some valuable minerals.");
                    break;
                case "2":
                    Console.WriteLine("You try to communicate with the aliens but they seem hostile. You narrowly escape and return to your spaceship.");
                    break;
                case "3":
                    Console.WriteLine("You return to your spaceship and prepare to continue your journey.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void TravelToStarSystem()
        {
            Console.WriteLine("You engage the warp drive and travel to a distant star system.");
            Console.WriteLine("You arrive at a binary star system with multiple planets orbiting the stars.");
            Console.WriteLine("You must choose which planet to explore next.");
            Console.WriteLine("1. Red planet");
            Console.WriteLine("2. Green planet");
            Console.WriteLine("3. Blue planet");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ExplorePlanet();
                    break;
                case "2":
                    ExplorePlanet();
                    break;
                case "3":
                    ExplorePlanet();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void CheckResources()
        {
            Console.WriteLine("You have the following resources:");
            Console.WriteLine("1. Fuel: 80%");
            Console.WriteLine("2. Food: 50%");
            Console.WriteLine("3. Minerals: 70%");
        }

        static void QuitGame()
        {
            Console.WriteLine("Thank you for playing Space Explorer. Goodbye!");
            Environment.Exit(0);
        }
    }
}

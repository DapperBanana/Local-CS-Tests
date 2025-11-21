
using System;

namespace SpaceExplorationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the space exploration game!");

            Console.WriteLine("You are the captain of a spaceship on a mission to explore the galaxy.");
            Console.WriteLine("You have just arrived at a remote planet. What do you want to do?");

            bool continueExploring = true;

            while (continueExploring)
            {
                Console.WriteLine("1. Explore the planet");
                Console.WriteLine("2. Refuel the spaceship");
                Console.WriteLine("3. Leave the planet");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ExplorePlanet();
                        break;
                    case 2:
                        RefuelSpaceship();
                        break;
                    case 3:
                        continueExploring = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            Console.WriteLine("Thanks for playing the space exploration game!");
        }

        static void ExplorePlanet()
        {
            Console.WriteLine("Exploring the planet...");
            Console.WriteLine("You find some rare minerals.");
        }

        static void RefuelSpaceship()
        {
            Console.WriteLine("Refueling the spaceship...");
            Console.WriteLine("Spaceship is now fully fueled.");
        }
    }
}

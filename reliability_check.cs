
using System;
using System.Threading;

class SpaceGame
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Space Exploration Game!");
        Console.WriteLine("You are the captain of a spaceship on a mission to explore deep space.");
        Console.WriteLine("You have limited resources and must make decisions wisely.");

        int resources = 100;
        int distance = 0;

        while (distance < 100)
        {
            Console.WriteLine("\nCurrent Distance from Earth: " + distance + " light years");
            Console.WriteLine("Current Resources: " + resources + " units");

            Console.WriteLine("\nChoose your action:");
            Console.WriteLine("1. Travel to a nearby star system");
            Console.WriteLine("2. Gather resources from a nearby asteroid field");
            Console.WriteLine("3. Rest and repair the ship");
            Console.WriteLine("4. Quit the game");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int travelCost = 10;
                    Console.WriteLine("\nTravelling to a nearby star system...");
                    Thread.Sleep(2000);
                    distance += 10;
                    resources -= travelCost;
                    break;

                case 2:
                    int resourceGain = 20;
                    Console.WriteLine("\nGathering resources from a nearby asteroid field...");
                    Thread.Sleep(2000);
                    resources += resourceGain;
                    break;

                case 3:
                    int repairCost = 30;
                    Console.WriteLine("\nResting and repairing the ship...");
                    Thread.Sleep(2000);
                    resources -= repairCost;
                    break;

                case 4:
                    Console.WriteLine("\nExiting the game...");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    break;
            }

            if (resources <= 0)
            {
                Console.WriteLine("\nYou have run out of resources. Game over.");
                break;
            }
        }

        Console.WriteLine("\nCongratulations! You have successfully explored deep space and completed your mission.");
    }
}

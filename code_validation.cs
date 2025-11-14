
using System;
using System.Threading;

class SpaceExplorationGame
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Space Exploration Game!");
        Console.WriteLine("You are about to embark on a journey to explore the vast unknown of space.");
        Console.WriteLine("You have limited resources and must make decisions carefully to survive.");

        int fuel = 100;
        int distanceTraveled = 0;

        while (fuel > 0)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Travel to a nearby planet");
            Console.WriteLine("2. Refuel your spaceship");
            Console.WriteLine("3. Quit the game");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int travelDistance = new Random().Next(10, 21);
                    Thread.Sleep(2000);
                    if (fuel < travelDistance)
                    {
                        Console.WriteLine("You don't have enough fuel to travel that far. Refuel your spaceship.");
                    }
                    else
                    {
                        distanceTraveled += travelDistance;
                        fuel -= travelDistance;
                        Console.WriteLine($"You traveled to a planet {travelDistance} light years away.");
                    }
                    break;
                case 2:
                    fuel = 100;
                    Console.WriteLine("You refueled your spaceship.");
                    break;
                case 3:
                    Console.WriteLine("Thanks for playing! You traveled a total of " + distanceTraveled + " light years.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine($"You have {fuel} units of fuel left. Total distance traveled: {distanceTraveled} light years.");
        }

        Console.WriteLine("You ran out of fuel and couldn't continue your journey. Game over.");
    }
}

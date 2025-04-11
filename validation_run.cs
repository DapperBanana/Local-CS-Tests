
using System;

namespace SpaceshipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize player's spaceship
            int health = 100;
            int fuel = 100;
            int credits = 0;

            Console.WriteLine("Welcome to the Spaceship Game!\n");

            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Travel to a new planet");
                Console.WriteLine("2. Refuel your spaceship");
                Console.WriteLine("3. Quit the game\n");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (fuel < 20)
                        {
                            Console.WriteLine("Not enough fuel to travel. Refuel your spaceship!");
                        }
                        else
                        {
                            Random rnd = new Random();
                            int travelCost = rnd.Next(10, 20);
                            fuel -= travelCost;

                            int encounterResult = rnd.Next(1, 4);
                            if (encounterResult == 1)
                            {
                                int enemyStrength = rnd.Next(20, 50);
                                health -= enemyStrength;
                                Console.WriteLine($"You encountered an enemy spaceship with strength {enemyStrength}. Your spaceship health is now {health}.");

                                if (health <= 0)
                                {
                                    Console.WriteLine("Your spaceship was destroyed. Game over!");
                                    return;
                                }
                            }
                            else
                            {
                                int creditsGained = rnd.Next(5, 10);
                                credits += creditsGained;
                                Console.WriteLine($"You successfully traveled to a new planet and earned {creditsGained} credits. Credits: {credits}");
                            }
                        }
                        break;
                    case "2":
                        fuel = 100;
                        Console.WriteLine("Spaceship refueled. Fuel: 100");
                        break;
                    case "3":
                        Console.WriteLine("Thanks for playing!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}

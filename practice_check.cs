
using System;

namespace SpaceshipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int distanceTraveled = 0;
            bool gameOver = false;

            Console.WriteLine("Welcome to the Spaceship Game!");

            while (!gameOver)
            {
                Console.WriteLine("\n1. Continue flying");
                Console.WriteLine("2. Stop and repair the spaceship");
                Console.WriteLine("3. Exit game");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        int randomDamage = new Random().Next(10, 20);
                        health -= randomDamage;
                        distanceTraveled += new Random().Next(5, 15);
                        Console.WriteLine($"Taking off! Health decreased by {randomDamage}. Distance traveled: {distanceTraveled}");
                        if (health <= 0)
                        {
                            Console.WriteLine("Your spaceship has been destroyed. Game over!");
                            gameOver = true;
                        }
                        break;

                    case 2:
                        health = 100;
                        Console.WriteLine("Spaceship repaired to full health.");
                        break;

                    case 3:
                        Console.WriteLine("Exiting game...");
                        gameOver = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}

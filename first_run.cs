
using System;

namespace SpaceshipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Spaceship Game!");
            Console.WriteLine("You are the captain of a spaceship. Your mission is to explore the galaxy and collect resources.");
            
            int resources = 0;
            int health = 100;

            bool gameOver = false;

            while (!gameOver)
            {
                Console.WriteLine("Options:");
                Console.WriteLine("1. Explore new planet");
                Console.WriteLine("2. Collect resources");
                Console.WriteLine("3. Check spaceship status");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("You have discovered a new planet!");
                        resources += 50;
                        health -= 10;
                        break;
                    case "2":
                        Console.WriteLine("You have collected resources!");
                        resources += 20;
                        break;
                    case "3":
                        Console.WriteLine("Ship status: ");
                        Console.WriteLine("Resources: " + resources);
                        Console.WriteLine("Health: " + health);
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again");
                        break;
                }

                if (health <= 0)
                {
                    Console.WriteLine("Your spaceship has been destroyed. Game over!");
                    gameOver = true;
                }
            }
        }
    }
}

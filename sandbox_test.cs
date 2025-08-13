
using System;

namespace SpaceshipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Spaceship Game!");
            Console.WriteLine("You are piloting a spaceship through an asteroid field.");

            int health = 100;
            int score = 0;

            while (health > 0)
            {
                Console.WriteLine("\nYour health: " + health);
                Console.WriteLine("Your score: " + score);
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Navigate through asteroids");
                Console.WriteLine("2. Refuel at nearby space station");
                Console.WriteLine("3. Exit the game");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Random rand = new Random();
                        int damage = rand.Next(10, 50);
                        health -= damage;
                        score += 10;
                        Console.WriteLine("You navigated through the asteroids and took " + damage + " damage.");
                        break;

                    case 2:
                        health = 100;
                        Console.WriteLine("You refueled at the space station and restored your health to 100.");
                        break;

                    case 3:
                        Console.WriteLine("Exiting the game...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            Console.WriteLine("Game over! Your final score is: " + score);
        }
    }
}

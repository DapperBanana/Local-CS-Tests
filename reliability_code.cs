
using System;

class Program
{
    static void Main()
    {
        int health = 100;
        int score = 0;

        Console.WriteLine("Welcome to the Spaceship Game!");

        while (health > 0)
        {
            Console.WriteLine("\nCurrent Health: " + health);
            Console.WriteLine("Current Score: " + score);
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Attack enemy ship");
            Console.WriteLine("2. Repair spaceship");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("You attack an enemy ship! +10 score");
                score += 10;
                health -= 20;
            }
            else if (choice == 2)
            {
                Console.WriteLine("You repair your spaceship! +5 health");
                health += 5;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        Console.WriteLine("\nGame over! Your final score is: " + score);
    }
}

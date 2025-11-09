
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Adventure Quest!");
        Console.WriteLine("Choose your character class:");
        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Mage");
        Console.WriteLine("3. Rogue");

        int choice = Convert.ToInt32(Console.ReadLine());

        string playerClass = "";

        switch (choice)
        {
            case 1:
                playerClass = "Warrior";
                break;
            case 2:
                playerClass = "Mage";
                break;
            case 3:
                playerClass = "Rogue";
                break;
            default:
                playerClass = "Unknown";
                break;
        }

        Console.WriteLine($"You have chosen the {playerClass} class.");

        Console.WriteLine("Let the adventure begin!");

        int health = 100;
        int gold = 0;

        while (health > 0)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Explore");
            Console.WriteLine("2. Rest");
            Console.WriteLine("3. Quit");

            int action = Convert.ToInt32(Console.ReadLine());

            if (action == 1)
            {
                int damageTaken = new Random().Next(1, 20);
                health -= damageTaken;
                gold += new Random().Next(1, 10);
                Console.WriteLine($"You explored and took {damageTaken} damage. Current health: {health}. Current gold: {gold}");
            }
            else if (action == 2)
            {
                health += new Random().Next(1, 10);
                Console.WriteLine($"You rested and gained some health. Current health: {health}. Current gold: {gold}");
            }
            else if (action == 3)
            {
                Console.WriteLine("Thanks for playing Adventure Quest!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        if (health <= 0)
        {
            Console.WriteLine("Game over! You have been defeated.");
        }
    }
}

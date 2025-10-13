
using System;

class Program
{
    static void Main()
    {
        int spaceshipHealth = 100;
        int enemyHealth = 50;
        bool spaceshipDestroyed = false;

        Console.WriteLine("Welcome to the spaceship game!");

        while (!spaceshipDestroyed)
        {
            Console.WriteLine($"Your spaceship health: {spaceshipHealth}");
            Console.WriteLine($"Enemy spaceship health: {enemyHealth}");
            Console.WriteLine("Choose an action: \n1. Attack\n2. Repair\n3. Quit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int damageDealt = new Random().Next(5, 20);
                    enemyHealth -= damageDealt;
                    Console.WriteLine($"You dealt {damageDealt} damage to the enemy spaceship!");
                    break;
                case 2:
                    int repair = new Random().Next(10, 30);
                    spaceshipHealth += repair;
                    Console.WriteLine($"You repaired your spaceship by {repair} points!");
                    break;
                case 3:
                    Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Choose a valid option.");
                    break;
            }

            if (enemyHealth <= 0)
            {
                Console.WriteLine("Congratulations! You defeated the enemy spaceship!");
                spaceshipDestroyed = true;
            }

            if (spaceshipHealth <= 0)
            {
                Console.WriteLine("Game over! Your spaceship has been destroyed!");
                spaceshipDestroyed = true;
            }
        }
    }
}

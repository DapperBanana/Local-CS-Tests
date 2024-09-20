
using System;

class Program
{
    static void Main()
    {
        int playerHealth = 100;
        int enemyHealth = 100;

        Console.WriteLine("Welcome to the trading card game!");

        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine("Player Health: {0}", playerHealth);
            Console.WriteLine("Enemy Health: {0}", enemyHealth);

            Console.WriteLine("Select an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            Console.WriteLine("3. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int playerDamage = new Random().Next(10, 20);
                    enemyHealth -= playerDamage;
                    Console.WriteLine("Player dealt {0} damage to enemy!", playerDamage);

                    int enemyDamage = new Random().Next(5, 15);
                    playerHealth -= enemyDamage;
                    Console.WriteLine("Enemy dealt {0} damage to player!", enemyDamage);
                    break;
                case 2:
                    Console.WriteLine("Player defended against enemy's attack!");
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }

        if (playerHealth <= 0)
        {
            Console.WriteLine("Player has been defeated. Game over.");
        }
        else if (enemyHealth <= 0)
        {
            Console.WriteLine("Player has defeated the enemy. Congratulations, you win!");
        }
    }
}

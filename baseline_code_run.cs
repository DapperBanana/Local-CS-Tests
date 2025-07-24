
using System;

class Program
{
    static int playerHealth = 100;
    static int enemyHealth = 50;
    static Random rand = new Random();

    static void Main()
    {
        Console.WriteLine("Welcome to the text-based RPG game!");

        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine("Player Health: " + playerHealth);
            Console.WriteLine("Enemy Health: " + enemyHealth);

            int playerDamage = rand.Next(10, 15);
            int enemyDamage = rand.Next(5, 10);

            Console.WriteLine("Player attacks the enemy and deals " + playerDamage + " damage!");
            enemyHealth -= playerDamage;

            if (enemyHealth <= 0)
            {
                Console.WriteLine("Enemy defeated! You win!");
                break;
            }

            Console.WriteLine("Enemy attacks the player and deals " + enemyDamage + " damage!");
            playerHealth -= enemyDamage;

            if (playerHealth <= 0)
            {
                Console.WriteLine("Player defeated! Game over.");
                break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}

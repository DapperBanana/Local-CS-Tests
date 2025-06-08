
using System;

class Program
{
    static void Main()
    {
        int playerHealth = 100;
        int enemyHealth = 100;

        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine("Player Health: " + playerHealth);
            Console.WriteLine("Enemy Health: " + enemyHealth);
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Random rand = new Random();
                int playerDamage = rand.Next(5, 15);
                int enemyDamage = rand.Next(5, 15);

                enemyHealth -= playerDamage;
                playerHealth -= enemyDamage;

                Console.WriteLine("You attack the enemy for " + playerDamage + " damage!");
                Console.WriteLine("The enemy attacks you for " + enemyDamage + " damage!");
            }
            else if (choice == 2)
            {
                Console.WriteLine("You defend against the enemy's attack!");
                int enemyDamage = new Random().Next(5, 15);
                playerHealth -= enemyDamage;
                Console.WriteLine("The enemy attacks you for " + enemyDamage + " damage!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        if (playerHealth <= 0)
        {
            Console.WriteLine("You lose. Game over.");
        }
        else
        {
            Console.WriteLine("You win! Congratulations!");
        }
    }
}

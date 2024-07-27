
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Trading Card Game!");

        int playerHealth = 100;
        int enemyHealth = 100;

        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine("Player Health: " + playerHealth);
            Console.WriteLine("Enemy Health: " + enemyHealth);

            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                int playerAttack = new Random().Next(10, 20);
                int enemyAttack = new Random().Next(5, 15);

                Console.WriteLine("Player attacks for " + playerAttack + " damage!");
                enemyHealth -= playerAttack;

                Console.WriteLine("Enemy attacks for " + enemyAttack + " damage!");
                playerHealth -= enemyAttack;
            }
            else if (choice == 2)
            {
                int enemyAttack = new Random().Next(5, 15);

                Console.WriteLine("Player defends and takes reduced damage!");
                playerHealth -= enemyAttack / 2;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        if (playerHealth <= 0)
        {
            Console.WriteLine("You have been defeated. Game over.");
        }
        else if (enemyHealth <= 0)
        {
            Console.WriteLine("You have defeated the enemy. Congratulations!");
        }
    }
}

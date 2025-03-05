
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Text-Based RPG Battle System!");

        // Player stats
        int playerHealth = 100;
        int playerAttack = 10;

        // Enemy stats
        int enemyHealth = 50;
        int enemyAttack = 5;

        bool playerTurn = true;

        while (playerHealth > 0 && enemyHealth > 0)
        {
            if (playerTurn)
            {
                Console.WriteLine("Player's turn. Choose an action:");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");
                
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Player attacks the enemy for " + playerAttack + " damage!");
                    enemyHealth -= playerAttack;
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Player defends against the enemy's attack!");
                }
            }
            else
            {
                Console.WriteLine("Enemy's turn. Enemy attacks the player for " + enemyAttack + " damage!");
                playerHealth -= enemyAttack;
            }

            Console.WriteLine("Player health: " + playerHealth);
            Console.WriteLine("Enemy health: " + enemyHealth);
            Console.WriteLine();

            playerTurn = !playerTurn;
        }

        if (playerHealth <= 0)
        {
            Console.WriteLine("Game over. You are defeated.");
        }
        else
        {
            Console.WriteLine("Congratulations! You have defeated the enemy!");
        }
    }
}

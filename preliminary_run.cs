
using System;

namespace TradingCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Trading Card Game!");

            bool gameOver = false;
            int playerHealth = 100;
            int enemyHealth = 100;

            Random rng = new Random();

            while (!gameOver)
            {
                Console.WriteLine("Player Health: " + playerHealth);
                Console.WriteLine("Enemy Health: " + enemyHealth);

                int playerAttack = rng.Next(10, 20);
                int enemyAttack = rng.Next(5, 15);

                Console.WriteLine("Player attacks the enemy for " + playerAttack + " damage!");
                enemyHealth -= playerAttack;

                if (enemyHealth <= 0)
                {
                    Console.WriteLine("Player wins!");
                    gameOver = true;
                    break;
                }

                Console.WriteLine("Enemy attacks the player for " + enemyAttack + " damage!");
                playerHealth -= enemyAttack;

                if (playerHealth <= 0)
                {
                    Console.WriteLine("Enemy wins!");
                    gameOver = true;
                    break;
                }

                Console.WriteLine("Press any key to continue to the next round...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

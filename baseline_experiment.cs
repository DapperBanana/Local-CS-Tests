
using System;

namespace TradingCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playerTurn = true;
            int playerHealth = 100;
            int enemyHealth = 100;

            Console.WriteLine("Welcome to the Trading Card Game!");

            while (playerHealth > 0 && enemyHealth > 0)
            {
                if (playerTurn)
                {
                    Console.WriteLine("Player's turn. Choose an action:");
                    Console.WriteLine("1. Attack");
                    Console.WriteLine("2. Defend");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            enemyHealth -= 10;
                            break;
                        case 2:
                            playerHealth += 5;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enemy's turn. Enemy attacks!");
                    playerHealth -= 10;
                }

                playerTurn = !playerTurn;

                Console.WriteLine($"Player health: {playerHealth}");
                Console.WriteLine($"Enemy health: {enemyHealth}");
                Console.WriteLine();
            }

            if (playerHealth <= 0)
            {
                Console.WriteLine("Game over. You lose.");
            }
            else
            {
                Console.WriteLine("Congratulations! You win.");
            }
        }
    }
}

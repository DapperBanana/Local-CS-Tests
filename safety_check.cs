
using System;

namespace TradingCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Trading Card Game!");

            // Generate player stats
            int playerHealth = 100;
            int playerAttack = 10;

            // Generate opponent stats
            int opponentHealth = 100;
            int opponentAttack = 8;

            // Game loop
            while (playerHealth > 0 && opponentHealth > 0)
            {
                Console.WriteLine("Player Health: " + playerHealth);
                Console.WriteLine("Opponent Health: " + opponentHealth);
                Console.WriteLine("Choose an action: ");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");
                int choice = Convert.ToInt32(Console.ReadLine());

                // Player chooses to attack
                if (choice == 1)
                {
                    opponentHealth -= playerAttack;
                    Console.WriteLine("Player attacks! Opponent takes " + playerAttack + " damage.");
                }
                // Player chooses to defend
                else if (choice == 2)
                {
                    playerHealth += opponentAttack / 2;
                    Console.WriteLine("Player defends! Player gains " + opponentAttack / 2 + " health.");
                }

                // Opponent attacks
                playerHealth -= opponentAttack;
                Console.WriteLine("Opponent attacks! Player takes " + opponentAttack + " damage.");

                // Check for game over
                if (playerHealth <= 0)
                {
                    Console.WriteLine("Player has been defeated. Game over!");
                }
                else if (opponentHealth <= 0)
                {
                    Console.WriteLine("Opponent has been defeated. You win!");
                }
            }
        }
    }
}

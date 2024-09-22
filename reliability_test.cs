
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the trading card game!");

        // Player starts with some initial health and attack power
        int playerHealth = 100;
        int playerAttackPower = 10;

        // Opponent starts with some initial health and attack power
        int opponentHealth = 100;
        int opponentAttackPower = 10;

        // Main game loop
        while (playerHealth > 0 && opponentHealth > 0)
        {
            Console.WriteLine($"Player Health: {playerHealth} | Opponent Health: {opponentHealth}");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            Console.Write("Choose your move: ");

            string input = Console.ReadLine();

            if (input == "1")
            {
                // Player attacks opponent
                opponentHealth -= playerAttackPower;
                Console.WriteLine("Player attacks opponent for " + playerAttackPower + " damage.");
            }
            else if (input == "2")
            {
                // Player defends against opponent's attack
                // For simplicity, opponent always attacks
                int damageTaken = opponentAttackPower / 2;
                playerHealth -= damageTaken;
                Console.WriteLine("Opponent attacks player for " + damageTaken + " damage while defending.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please choose a valid move.");
            }

            // Opponent's turn to attack
            playerHealth -= opponentAttackPower;
            Console.WriteLine("Opponent attacks player for " + opponentAttackPower + " damage.");

            // Check if player or opponent has lost
            if (playerHealth <= 0)
            {
                Console.WriteLine("Player has been defeated. Game over!");
            }
            else if (opponentHealth <= 0)
            {
                Console.WriteLine("Opponent has been defeated. Congratulations, you win!");
            }
        }
    }
}

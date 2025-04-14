
using System;

namespace TextBasedRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Text-Based RPG Game!");
            Console.WriteLine("What is your name, adventurer?");
            string playerName = Console.ReadLine();

            Console.WriteLine($"Welcome, {playerName}! Your journey begins now.");

            int playerHealth = 100;
            int playerAttack = 10;
            int enemyHealth = 50;
            int enemyAttack = 5;

            while (playerHealth > 0 && enemyHealth > 0)
            {
                Console.WriteLine($"Player Health: {playerHealth} Enemy Health: {enemyHealth}");
                Console.WriteLine("1. Fight");
                Console.WriteLine("2. Run");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    enemyHealth -= playerAttack;
                    playerHealth -= enemyAttack;
                    Console.WriteLine($"You attack the enemy and deal {playerAttack} damage.");
                    Console.WriteLine($"The enemy attacks you and deals {enemyAttack} damage.");
                }
                else if (input == "2")
                {
                    Console.WriteLine("You run away from the enemy. Coward!");
                    break;
                }
            }

            if (playerHealth > 0)
            {
                Console.WriteLine("Congratulations! You have defeated the enemy and won the game.");
            }
            else
            {
                Console.WriteLine("Game over. The enemy has defeated you.");
            }
        }
    }
}

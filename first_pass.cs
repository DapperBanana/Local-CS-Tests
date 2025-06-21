
using System;

namespace TextBasedRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Text-Based RPG Battle System!");

            // Player stats
            int playerHealth = 100;
            int playerAttack = 10;

            // Enemy stats
            int enemyHealth = 50;
            int enemyAttack = 5;

            // Battle loop
            while (playerHealth > 0 && enemyHealth > 0)
            {
                Console.WriteLine("Player Health: " + playerHealth);
                Console.WriteLine("Enemy Health: " + enemyHealth);
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");
                Console.Write("Choose your action: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    // Player attacks
                    int damage = playerAttack + new Random().Next(-2, 3);
                    enemyHealth -= damage;
                    Console.WriteLine("You hit the enemy for " + damage + " damage!");
                }
                else if (input == "2")
                {
                    // Player defends
                    int damage = enemyAttack - 2;
                    if (damage < 0) damage = 0;
                    playerHealth -= damage;
                    Console.WriteLine("You defend and take " + damage + " damage!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                // Enemy attacks
                int enemyDamage = enemyAttack + new Random().Next(-1, 2);
                playerHealth -= enemyDamage;
                Console.WriteLine("The enemy hits you for " + enemyDamage + " damage!");

                // Check if battle is over
                if (playerHealth <= 0)
                {
                    Console.WriteLine("You have been defeated. Game Over!");
                }
                else if (enemyHealth <= 0)
                {
                    Console.WriteLine("You have defeated the enemy. Victory!");
                }
            }
        }
    }
}

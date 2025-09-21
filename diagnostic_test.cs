
using System;

namespace TextTradingCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHealth = 20;
            int enemyHealth = 20;
            Random rand = new Random();

            Console.WriteLine("Welcome to Text Trading Card Game!");

            while (playerHealth > 0 && enemyHealth > 0)
            {
                Console.WriteLine("Player Health: " + playerHealth);
                Console.WriteLine("Enemy Health: " + enemyHealth);

                Console.WriteLine("Choose your action:");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");

                int playerAction = int.Parse(Console.ReadLine());

                int enemyAction = rand.Next(1, 3);

                if (playerAction == 1)
                {
                    enemyHealth -= 3;
                    Console.WriteLine("Player attacks enemy for 3 damage!");
                }
                else if (playerAction == 2)
                {
                    playerHealth += 1;
                    Console.WriteLine("Player gains 1 health from defending!");
                }

                if (enemyAction == 1)
                {
                    playerHealth -= 2;
                    Console.WriteLine("Enemy attacks player for 2 damage!");
                }
                else if (enemyAction == 2)
                {
                    enemyHealth += 1;
                    Console.WriteLine("Enemy gains 1 health from defending!");
                }

            }

            if (playerHealth <= 0)
            {
                Console.WriteLine("Player has been defeated. Game over!");
            }
            else if (enemyHealth <= 0)
            {
                Console.WriteLine("Enemy has been defeated. Congratulations, you win!");
            }
        }
    }
}

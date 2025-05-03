
using System;

class Program
{
    static void Main()
    {
        bool gameOver = false;
        Random random = new Random();
        int playerHealth = 100;
        int enemyHealth = 100;

        Console.WriteLine("Welcome to the Trading Card Game!");

        while (!gameOver)
        {
            Console.WriteLine("\nPlayer Health: " + playerHealth);
            Console.WriteLine("Enemy Health: " + enemyHealth);

            int playerDamage = random.Next(5, 15);
            int enemyDamage = random.Next(5, 15);

            Console.WriteLine("\nPlayer attacks enemy for " + playerDamage + " damage!");
            enemyHealth -= playerDamage;

            if (enemyHealth <= 0)
            {
                Console.WriteLine("\nPlayer wins!");
                gameOver = true;
                break;
            }

            Console.WriteLine("\nEnemy attacks player for " + enemyDamage + " damage!");
            playerHealth -= enemyDamage;

            if (playerHealth <= 0)
            {
                Console.WriteLine("\nEnemy wins!");
                gameOver = true;
                break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}

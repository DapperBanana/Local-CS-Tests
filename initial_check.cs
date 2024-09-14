
using System;

class Program
{
    public static int playerHealth = 100;
    public static int enemyHealth = 50;

    static void Main()
    {
        Console.WriteLine("Welcome to Text-based RPG Game!");

        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine("\nPlayer Health: " + playerHealth);
            Console.WriteLine("Enemy Health: " + enemyHealth);

            Console.WriteLine("\n1. Attack");
            Console.WriteLine("2. Defend");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                int damage = new Random().Next(5, 10);
                enemyHealth -= damage;
                Console.WriteLine("You hit the enemy for " + damage + " damage.");
            }
            else if (choice == 2)
            {
                int damage = new Random().Next(1, 5);
                playerHealth -= damage;
                Console.WriteLine("You defended but took " + damage + " damage from the enemy.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            if (enemyHealth <= 0)
            {
                Console.WriteLine("You defeated the enemy! Congratulations!");
            }
            else if (playerHealth <= 0)
            {
                Console.WriteLine("You were defeated by the enemy. Game Over!");
            }

        }

        Console.WriteLine("\nGame Over. Thank you for playing!");
    }
}

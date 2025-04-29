
using System;

class Program
{
    static int playerHealth = 100;
    static int enemyHealth = 50;
    static int playerDamage = 10;
    static int enemyDamage = 5;

    static void Main()
    {
        Console.WriteLine("Welcome to the Spaceship Game!");

        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine("Player Health: " + playerHealth);
            Console.WriteLine("Enemy Health: " + enemyHealth);
            Console.WriteLine("\n1. Attack");
            Console.WriteLine("2. Retreat");

            Console.Write("Choose your action: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    playerAttack();
                    if (enemyHealth > 0)
                    {
                        enemyAttack();
                    }
                    break;
                case 2:
                    Console.WriteLine("You retreat from the battle.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        if (playerHealth <= 0)
        {
            Console.WriteLine("You have been defeated. Game over!");
        }
        else if (enemyHealth <= 0)
        {
            Console.WriteLine("You have defeated the enemy. Congratulations!");
        }
    }

    static void playerAttack()
    {
        enemyHealth -= playerDamage;
        Console.WriteLine("Player attacks the enemy. Enemy loses " + playerDamage + " health.");
    }

    static void enemyAttack()
    {
        playerHealth -= enemyDamage;
        Console.WriteLine("Enemy attacks the player. Player loses " + enemyDamage + " health.");
    }
}

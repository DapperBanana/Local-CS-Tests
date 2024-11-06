
using System;

class Program
{
    static int playerHealth = 100;
    static int enemyHealth = 50;

    static void Main()
    {
        Console.WriteLine("Welcome to Text RPG Game!");

        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine("\nPlayer Health: " + playerHealth);
            Console.WriteLine("Enemy Health: " + enemyHealth);
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Attack();
                    break;
                case 2:
                    Heal();
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }

        if (playerHealth <= 0)
        {
            Console.WriteLine("Game Over! You lost.");
        }
        else
        {
            Console.WriteLine("Congratulations! You defeated the enemy.");
        }

    }

    static void Attack()
    {
        int damage = new Random().Next(5, 15);
        enemyHealth -= damage;
        Console.WriteLine("You attacked the enemy for " + damage + " damage.");

        int enemyDamage = new Random().Next(3, 10);
        playerHealth -= enemyDamage;
        Console.WriteLine("The enemy attacked you for " + enemyDamage + " damage.");
    }

    static void Heal()
    {
        int healAmount = new Random().Next(10, 20);
        playerHealth += healAmount;
        Console.WriteLine("You healed yourself for " + healAmount + " health.");

        int enemyDamage = new Random().Next(3, 10);
        playerHealth -= enemyDamage;
        Console.WriteLine("The enemy attacked you for " + enemyDamage + " damage.");
    }
}


using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int playerHealth = 100;
        int enemyHealth = 100;

        Console.WriteLine("Welcome to the RPG Battle System!");

        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine("\nPlayer Health: " + playerHealth);
            Console.WriteLine("Enemy Health: " + enemyHealth);
            Console.WriteLine("\n1. Attack");
            Console.WriteLine("2. Defend");
            Console.Write("Choose an action: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            int playerDamage = random.Next(5, 10);
            int enemyDamage = random.Next(5, 10);

            switch (choice)
            {
                case 1:
                    enemyHealth -= playerDamage;
                    playerHealth -= enemyDamage;
                    Console.WriteLine("\nPlayer attacks and deals " + playerDamage + " damage!");
                    Console.WriteLine("Enemy attacks and deals " + enemyDamage + " damage!");
                    break;

                case 2:
                    playerHealth -= enemyDamage / 2;
                    Console.WriteLine("\nPlayer defends and takes " + (enemyDamage / 2) + " damage!");
                    break;

                default:
                    Console.WriteLine("\nInvalid choice! Try again.");
                    break;
            }
        }

        if (playerHealth <= 0)
        {
            Console.WriteLine("\nPlayer has been defeated! Game Over.");
        }
        else
        {
            Console.WriteLine("\nEnemy has been defeated! You win!");
        }

        Console.WriteLine("Thanks for playing!");
    }
}

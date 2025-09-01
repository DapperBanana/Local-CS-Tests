
using System;

class Program
{
    static void Main()
    {
        int playerHealth = 100;
        int enemyHealth = 50;
        Random random = new Random();

        Console.WriteLine("Welcome to the Space Adventure Game!");

        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine("Player Health: " + playerHealth);
            Console.WriteLine("Enemy Health: " + enemyHealth);
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                int playerDamage = random.Next(5, 10);
                int enemyDamage = random.Next(5, 10);

                enemyHealth -= playerDamage;
                playerHealth -= enemyDamage;

                Console.WriteLine("You hit the enemy for " + playerDamage + " damage!");
                Console.WriteLine("The enemy hits you for " + enemyDamage + " damage!");
            }
            else if (choice == 2)
            {
                int enemyDamage = random.Next(0, 5);

                playerHealth -= enemyDamage;

                Console.WriteLine("You defended and received " + enemyDamage + " damage!");
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }

        if (playerHealth <= 0)
        {
            Console.WriteLine("Game Over! You have been defeated.");
        }
        else
        {
            Console.WriteLine("Congratulations! You have defeated the enemy and won the game!");
        }
    }
}

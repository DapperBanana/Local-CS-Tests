
using System;

class Program
{
    static void Main()
    {
        int playerHealth = 100;
        int enemyHealth = 50;
        Random random = new Random();

        Console.WriteLine("Welcome to the Text-Based RPG Game!");

        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine("\nPlayer Health: {0}", playerHealth);
            Console.WriteLine("Enemy Health: {0}", enemyHealth);

            Console.WriteLine("\n1. Attack");
            Console.WriteLine("2. Defend");
            Console.WriteLine("3. Run");

            Console.Write("Choose an action: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                int damage = random.Next(5, 10);
                enemyHealth -= damage;
                Console.WriteLine("You attack the enemy for {0} damage!", damage);
            }
            else if (choice == 2)
            {
                playerHealth += 5;
                Console.WriteLine("You defend and heal for 5 health points.");
            }
            else if (choice == 3)
            {
                Console.WriteLine("You run away from the enemy. Coward.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }

            int enemyDamage = random.Next(3, 8);
            playerHealth -= enemyDamage;
            Console.WriteLine("The enemy attacks you for {0} damage!", enemyDamage);
        }

        if (playerHealth <= 0)
        {
            Console.WriteLine("\nYou have been defeated by the enemy. Game over.");
        }
        else if (enemyHealth <= 0)
        {
            Console.WriteLine("\nYou have defeated the enemy. Congratulations, you win!");
        }
    }
}

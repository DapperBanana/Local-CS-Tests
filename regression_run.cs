
using System;

class Program
{
    static int health = 100;
    static int attack = 10;
    static int defense = 5;

    static void Main()
    {
        Console.WriteLine("Welcome to the Text-Based RPG Game!");
        Console.WriteLine("Your stats: Health: {0}, Attack: {1}, Defense: {2}", health, attack, defense);

        bool gameOver = false;

        while (!gameOver)
        {
            Console.WriteLine("\n1. Explore");
            Console.WriteLine("2. Rest");
            Console.WriteLine("3. Quit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Explore();
                    break;
                case 2:
                    Rest();
                    break;
                case 3:
                    gameOver = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (health <= 0)
            {
                Console.WriteLine("Game over! Your health dropped to 0.");
                gameOver = true;
            }
        }
    }

    static void Explore()
    {
        Console.WriteLine("You encountered an enemy!");
        int enemyHealth = 50;
        int enemyAttack = 8;
        int enemyDefense = 3;

        while (health > 0 && enemyHealth > 0)
        {
            int playerDamage = Math.Max(attack - enemyDefense, 0);
            int enemyDamage = Math.Max(enemyAttack - defense, 0);

            Console.WriteLine("\nYour health: {0}, Enemy health: {1}", health, enemyHealth);
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    enemyHealth -= playerDamage;
                    Console.WriteLine("You dealt {0} damage to the enemy.", playerDamage);
                    break;
                case 2:
                    health -= enemyDamage;
                    Console.WriteLine("You took {0} damage from the enemy.", enemyDamage);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        if (health > 0)
        {
            Console.WriteLine("You defeated the enemy!");
        }
        else
        {
            Console.WriteLine("You were defeated by the enemy.");
        }
    }

    static void Rest()
    {
        health = Math.Min(health + 20, 100);
        Console.WriteLine("You have rested and restored 20 health. Your health is now {0}.", health);
    }
}

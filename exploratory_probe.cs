
using System;

class Program
{
    static void Main()
    {
        int health = 100;
        int enemyHealth = 50;
        int damage = 20;
        bool gameOver = false;

        Console.WriteLine("Welcome to the Space Adventure Game!");

        while (!gameOver)
        {
            Console.WriteLine("\nYour spaceship's health: " + health);
            Console.WriteLine("Enemy spaceship's health: " + enemyHealth);

            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Retreat");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    enemyHealth -= damage;
                    Console.WriteLine("You attacked the enemy spaceship!");
                    break;
                case 2:
                    Console.WriteLine("You retreated from battle!");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            if (enemyHealth <= 0)
            {
                Console.WriteLine("Congratulations! You defeated the enemy spaceship!");
                gameOver = true;
            }

            if (health <= 0)
            {
                Console.WriteLine("Game Over! Your spaceship was destroyed by the enemy!");
                gameOver = true;
            }
        }
    }
}

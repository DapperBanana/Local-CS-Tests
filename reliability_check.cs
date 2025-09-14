
using System;

class Program
{
    static void Main()
    {
        int spaceshipHealth = 100;
        int enemyHealth = 50;
        bool gameOver = false;

        Console.WriteLine("Welcome to Space Adventure! Your spaceship is under attack by enemy ships.");

        while (!gameOver)
        {
            Console.WriteLine("\nYour spaceship health: " + spaceshipHealth);
            Console.WriteLine("Enemy spaceship health: " + enemyHealth);
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            Console.WriteLine("3. Retreat");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    int damageDealt = new Random().Next(10, 21);
                    int damageTaken = new Random().Next(5, 16);
                    spaceshipHealth -= damageTaken;
                    enemyHealth -= damageDealt;
                    Console.WriteLine("\nYou dealt " + damageDealt + " damage to the enemy!");
                    Console.WriteLine("You took " + damageTaken + " damage in return.");
                    break;
                case 2:
                    spaceshipHealth += 10;
                    Console.WriteLine("\nYou choose to defend. Your health increased by 10.");
                    break;
                case 3:
                    Console.WriteLine("\nYou choose to retreat. Game over!");
                    gameOver = true;
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    continue;
            }

            if (spaceshipHealth <= 0)
            {
                Console.WriteLine("\nYour spaceship has been destroyed. Game over!");
                gameOver = true;
            }
            else if (enemyHealth <= 0)
            {
                Console.WriteLine("\nYou have defeated the enemy! Congratulations, you win!");
                gameOver = true;
            }
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        int health = 100;
        int score = 0;

        Console.WriteLine("Welcome to the Spaceship Game!");
        Console.WriteLine("Your health: " + health);
        Console.WriteLine("Your score: " + score);

        bool gameOver = false;
        while (!gameOver)
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Attack enemy");
            Console.WriteLine("2. Heal");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    health -= 20;
                    score += 10;
                    Console.WriteLine("You attacked the enemy! Your health: " + health + " Your score: " + score);
                    break;
                case 2:
                    health += 10;
                    Console.WriteLine("You healed yourself! Your health: " + health + " Your score: " + score);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            if (health <= 0)
            {
                gameOver = true;
                Console.WriteLine("Game over! Your final score: " + score);
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}

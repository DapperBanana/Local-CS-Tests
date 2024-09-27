
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Text RPG Game!");

        Console.Write("Enter your character's name: ");
        string playerName = Console.ReadLine();
        int playerHealth = 100;
        int playerAttack = 10;
        int enemyHealth = 50;
        int enemyAttack = 5;

        Console.WriteLine($"Welcome, {playerName}! Let's start the game.");

        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine($"{playerName}'s Health: {playerHealth}");
            Console.WriteLine($"Enemy's Health: {enemyHealth}");
            Console.WriteLine("Choose an action: ");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Run");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine($"{playerName} attacks the enemy!");
                enemyHealth -= playerAttack;
                Console.WriteLine($"Enemy's Health: {enemyHealth}");

                Console.WriteLine("Enemy attacks you!");
                playerHealth -= enemyAttack;
                Console.WriteLine($"{playerName}'s Health: {playerHealth}");
            }
            else if (input == "2")
            {
                Console.WriteLine($"{playerName} runs away from the battle!");
                break;
            }
        }

        if (playerHealth <= 0)
        {
            Console.WriteLine($"{playerName} was defeated. Game over!");
        }
        else
        {
            Console.WriteLine("Congratulations! You have defeated the enemy. You win!");
        }
    }
}

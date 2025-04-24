
using System;

class Program
{
    static void Main()
    {
        string playerName;
        
        Console.WriteLine("Welcome to the Text-Based RPG Game!");
        Console.Write("Enter your name: ");
        playerName = Console.ReadLine();
        
        Console.WriteLine($"Hello, {playerName}! Let's begin your adventure.");
        
        int playerHealth = 100;
        int enemyHealth = 50;
        int playerDamage = 10;
        int enemyDamage = 5;
        
        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine($"{playerName}'s Health: {playerHealth}");
            Console.WriteLine("Enemy's Health: {enemyHealth}");
            
            Console.WriteLine("Choose your action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Drink health potion (+20 health)");
            
            int choice = int.Parse(Console.ReadLine());
            
            if (choice == 1)
            {
                enemyHealth -= playerDamage;
                playerHealth -= enemyDamage;
                Console.WriteLine("You attack the enemy!");
            }
            else if (choice == 2)
            {
                playerHealth += 20;
                Console.WriteLine("You drink a health potion and regain 20 health.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
        
        if (playerHealth <= 0)
        {
            Console.WriteLine("Game Over. You have been defeated.");
        }
        else
        {
            Console.WriteLine("Congratulations! You have defeated the enemy.");
        }
    }
}

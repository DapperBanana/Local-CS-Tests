
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the RPG Battle System!");
        
        // Player stats
        int playerHealth = 100;
        int playerAttack = 10;
        
        // Enemy stats
        int enemyHealth = 50;
        int enemyAttack = 5;
        
        Console.WriteLine("Player Health: " + playerHealth);
        Console.WriteLine("Enemy Health: " + enemyHealth);
        
        // Battle loop
        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine("Choose your action: ");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            
            string input = Console.ReadLine();
            int action = int.Parse(input);
            
            if (action == 1) // Player attacks
            {
                enemyHealth -= playerAttack;
                Console.WriteLine("Player attacks! Enemy health: " + enemyHealth);
            }
            else if (action == 2) // Player defends
            {
                playerHealth -= enemyAttack;
                Console.WriteLine("Player defends! Player Health: " + playerHealth);
            }
            
            // Enemy attacks
            playerHealth -= enemyAttack;
            Console.WriteLine("Enemy attacks! Player health: " + playerHealth);
            
            // Check for game over
            if (playerHealth <= 0)
            {
                Console.WriteLine("You lose! Game Over.");
            }
            else if (enemyHealth <= 0)
            {
                Console.WriteLine("You win! Enemy defeated.");
            }
        }
        
        Console.ReadLine();
    }
}

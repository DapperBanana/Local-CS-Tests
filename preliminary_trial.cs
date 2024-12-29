
using System;

class Program
{
    static void Main()
    {
        
        int playerHealth = 20;
        int enemyHealth = 20;
        
        Console.WriteLine("Welcome to the Trading Card Game!");
        
        while(playerHealth > 0 && enemyHealth > 0)
        {
            // Display player and enemy health
            Console.WriteLine("Player Health: " + playerHealth);
            Console.WriteLine("Enemy Health: " + enemyHealth);
            
            // Player's turn
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            if(choice == 1)
            {
                enemyHealth -= 3; // Player attacks enemy
                Console.WriteLine("You attack the enemy for 3 damage!");
            }
            else if(choice == 2)
            {
                playerHealth += 2; // Player defends and gains 2 health
                Console.WriteLine("You defend and gain 2 health.");
            }
            
            // Enemy's turn
            int enemyChoice = new Random().Next(1, 3);
            
            if(enemyChoice == 1)
            {
                playerHealth -= 2; // Enemy attacks player
                Console.WriteLine("The enemy attacks you for 2 damage!");
            }
            else if(enemyChoice == 2)
            {
                enemyHealth += 1; // Enemy heals itself
                Console.WriteLine("The enemy heals itself for 1 health.");
            }
        }
        
        // Display the winner
        if(playerHealth <= 0)
        {
            Console.WriteLine("You lose! Game over.");
        }
        else
        {
            Console.WriteLine("Congratulations! You defeated the enemy!");
        }
        
        Console.ReadLine();
    }
}

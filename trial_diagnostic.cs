
using System;

class Program
{
    static void Main()
    {
        int playerHealth = 100;
        int enemyHealth = 50;
        
        Random rnd = new Random();
        
        Console.WriteLine("A wild monster appears!");
        
        while(playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine("Player Health: " + playerHealth);
            Console.WriteLine("Enemy Health: " + enemyHealth);
            
            Console.WriteLine("Choose an action: ");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            
            int choice = int.Parse(Console.ReadLine());
            
            switch(choice)
            {
                case 1:
                    int playerAttack = rnd.Next(5, 10);
                    int enemyAttack = rnd.Next(3, 8);
                    
                    enemyHealth -= playerAttack;
                    playerHealth -= enemyAttack;
                    
                    Console.WriteLine("Player attacks the enemy for " + playerAttack + " damage!");
                    Console.WriteLine("Enemy attacks the player for " + enemyAttack + " damage!");
                    break;
                case 2:
                    int playerDefend = rnd.Next(2, 5);
                    int enemyDefend = rnd.Next(1, 3);
                    
                    playerHealth += playerDefend;
                    enemyHealth += enemyDefend;
                    
                    Console.WriteLine("Player defends and restores " + playerDefend + " health!");
                    Console.WriteLine("Enemy defends and restores " + enemyDefend + " health!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        
        if(playerHealth <= 0)
        {
            Console.WriteLine("Player has been defeated. Game over!");
        }
        else
        {
            Console.WriteLine("Enemy has been defeated. Congratulations, you win!");
        }
    }
}

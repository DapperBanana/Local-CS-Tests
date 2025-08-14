
using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        
        // Player stats
        int playerHealth = 100;
        int playerAttack = 10;
        int playerDefense = 5;
        
        // Enemy stats
        int enemyHealth = rand.Next(50, 100);
        int enemyAttack = rand.Next(5, 15);
        int enemyDefense = rand.Next(1, 10);
        
        Console.WriteLine("You encounter an enemy with " + enemyHealth + " health!");
        
        while (playerHealth > 0 && enemyHealth > 0)
        {
            // Player turn
            int playerDamage = playerAttack - enemyDefense;
            if (playerDamage < 0)
                playerDamage = 0;
            
            enemyHealth -= playerDamage;
            Console.WriteLine("You attack the enemy for " + playerDamage + " damage.");
            
            if (enemyHealth <= 0)
            {
                Console.WriteLine("You defeated the enemy!");
                break;
            }
            
            // Enemy turn
            int enemyDamage = enemyAttack - playerDefense;
            if (enemyDamage < 0)
                enemyDamage = 0;
            
            playerHealth -= enemyDamage;
            Console.WriteLine("The enemy attacks you for " + enemyDamage + " damage.");
            
            if (playerHealth <= 0)
            {
                Console.WriteLine("You were defeated by the enemy.");
                break;
            }
        }
        
        Console.WriteLine("Game over. Your final health: " + playerHealth);
    }
}

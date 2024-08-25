
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int playerHealth = 100;
        int enemyHealth = 50;
        
        Console.WriteLine("Welcome to the RPG Battle System!");
        
        while(playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine("\nPlayer Health: {0}", playerHealth);
            Console.WriteLine("Enemy Health: {0}", enemyHealth);
            
            Console.WriteLine("\nChoose your action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            
            int playerChoice = int.Parse(Console.ReadLine());
            
            int playerDamage = random.Next(5, 10);
            int enemyDamage = random.Next(3, 8);
            
            if(playerChoice == 1)
            {
                Console.WriteLine("\nPlayer attacks the enemy!");
                enemyHealth -= playerDamage;
                Console.WriteLine("Player deals {0} damage to the enemy.", playerDamage);
            }
            else if(playerChoice == 2)
            {
                Console.WriteLine("\nPlayer defends against the enemy's attack.");
                playerHealth -= enemyDamage / 2;
                Console.WriteLine("Enemy deals {0} damage to the player.", enemyDamage / 2);
            }
            
            Console.WriteLine("\nEnemy attacks the player!");
            playerHealth -= enemyDamage;
            Console.WriteLine("Enemy deals {0} damage to the player.", enemyDamage);
            
            if(playerHealth <= 0)
            {
                Console.WriteLine("\nYou have been defeated.");
            }
            else if(enemyHealth <= 0)
            {
                Console.WriteLine("\nYou have defeated the enemy!");
            }
        }
        
        Console.WriteLine("\nGame Over!");
    }
}

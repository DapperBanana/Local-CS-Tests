
using System;

class RPGGame
{
    static void Main()
    {
        Console.WriteLine("Welcome to Text-Based RPG Game!");
        
        Player player = new Player();
        Enemy enemy = new Enemy();
        
        Console.WriteLine("Player has health: " + player.health);
        Console.WriteLine("Enemy has health: " + enemy.health);
        
        while(player.health > 0 && enemy.health > 0)
        {
            Console.WriteLine("Choose your action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            
            int choice = int.Parse(Console.ReadLine());
            
            switch(choice)
            {
                case 1:
                    player.Attack(enemy);
                    Console.WriteLine("Player dealt damage to enemy. Enemy health: " + enemy.health);
                    break;
                case 2:
                    player.Defend();
                    Console.WriteLine("Player is defending.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
            
            enemy.Attack(player);
            Console.WriteLine("Enemy dealt damage to player. Player health: " + player.health);
        }
        
        if(player.health <= 0)
        {
            Console.WriteLine("Player has been defeated. Game over!");
        }
        else
        {
            Console.WriteLine("Enemy has been defeated. You win!");
        }
    }
}

class Player
{
    public int health = 100;
    public int damage = 10;
    public bool isDefending = false;
    
    public void Attack(Enemy enemy)
    {
        if(enemy.isDefending)
        {
            enemy.health -= damage / 2;
        }
        else
        {
            enemy.health -= damage;
        }
    }
    
    public void Defend()
    {
        isDefending = true;
    }
}

class Enemy
{
    public int health = 50;
    public int damage = 5;
    public bool isDefending = false;
    
    public void Attack(Player player)
    {
        if(player.isDefending)
        {
            player.health -= damage / 2;
        }
        else
        {
            player.health -= damage;
        }
    }
}

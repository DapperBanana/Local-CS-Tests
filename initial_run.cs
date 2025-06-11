
using System;

class Program
{
    static void Main()
    {
        Player player = new Player("Hero", 100, 20);
        Enemy enemy = new Enemy("Monster", 50, 10);
        
        Console.WriteLine("A wild enemy appears!\n");

        while(player.IsAlive() && enemy.IsAlive())
        {
            Console.WriteLine($"Player HP: {player.Health} | Enemy HP: {enemy.Health}");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            
            string input = Console.ReadLine();
            
            switch(input)
            {
                case "1":
                    player.Attack(enemy);
                    break;
                case "2":
                    player.Heal();
                    break;
                default:
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
            
            if(enemy.IsAlive())
            {
                enemy.Attack(player);
            }
        }
        
        if(player.IsAlive())
        {
            Console.WriteLine("You defeated the enemy!");
        }
        else
        {
            Console.WriteLine("Game Over. You were defeated by the enemy.");
        }
    }
}

class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    
    public Character(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
    }
    
    public bool IsAlive()
    {
        return Health > 0;
    }
    
    public void Attack(Character target)
    {
        int damage = AttackPower;
        Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage!");
        target.Health -= damage;
    }
    
    public void Heal()
    {
        Health += 10;
        Console.WriteLine($"{Name} heals for 10 HP.");
    }
}

class Player : Character
{
    public Player(string name, int health, int attackPower) : base(name, health, attackPower)
    {
    }
}

class Enemy : Character
{
    public Enemy(string name, int health, int attackPower) : base(name, health, attackPower)
    {
    }
}

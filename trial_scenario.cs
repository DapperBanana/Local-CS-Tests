
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Text-based RPG Battle System!");

        Player player = new Player("Hero", 100, 10);
        Enemy enemy = new Enemy("Goblin", 50, 5);

        while (player.IsAlive && enemy.IsAlive)
        {
            Console.WriteLine($"{player.Name} has {player.Health} health.");
            Console.WriteLine($"{enemy.Name} has {enemy.Health} health.");

            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");

            string input = Console.ReadLine();

            if (input == "1")
            {
                player.Attack(enemy);
            }
            else if (input == "2")
            {
                player.Defend();
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }

            enemy.Attack(player);
        }

        if (player.IsAlive)
        {
            Console.WriteLine($"{player.Name} has defeated {enemy.Name}!");
        }
        else
        {
            Console.WriteLine($"{enemy.Name} has defeated {player.Name}!");
        }
    }
}

class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackDamage { get; set; }
    public bool IsAlive { get { return Health > 0; } }

    public Character(string name, int health, int attackDamage)
    {
        Name = name;
        Health = health;
        AttackDamage = attackDamage;
    }

    public void Attack(Character target)
    {
        int damage = AttackDamage;
        if (target.IsDefending)
        {
            damage /= 2;
        }

        Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage!");
        target.Health -= damage;
    }

    public void Defend()
    {
        IsDefending = true;
        Console.WriteLine($"{Name} is defending!");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage!");
    }
}

class Player : Character
{
    public bool IsDefending { get; private set; }

    public Player(string name, int health, int attackDamage)
        : base(name, health, attackDamage)
    {
        IsDefending = false;
    }

    public void RestoreHealth(int amount)
    {
        Health += amount;
        Console.WriteLine($"{Name} restores {amount} health!");
    }
}

class Enemy : Character
{
    public Enemy(string name, int health, int attackDamage)
        : base(name, health, attackDamage)
    {
    }
}

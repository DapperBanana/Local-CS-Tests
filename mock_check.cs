
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Text-based RPG game!");

        Player player = new Player("Player", 100, 10);
        Enemy enemy = new Enemy("Goblin", 50, 5);

        Console.WriteLine("A wild Goblin appears!");

        while (player.IsAlive() && enemy.IsAlive())
        {
            Console.WriteLine("Player HP: " + player.health);
            Console.WriteLine("Enemy HP: " + enemy.health);

            Console.WriteLine("Select an action: ");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");

            string input = Console.ReadLine();

            if (input == "1")
            {
                player.Attack(enemy);
            }
            else if (input == "2")
            {
                player.Heal();
            }

            enemy.Attack(player);
        }

        if (player.IsAlive())
        {
            Console.WriteLine("You defeated the Goblin!");
        }
        else
        {
            Console.WriteLine("Game over, you were defeated by the Goblin.");
        }
    }
}

class Character
{
    public string name;
    public int health;
    public int attackPower;

    public Character(string name, int health, int attackPower)
    {
        this.name = name;
        this.health = health;
        this.attackPower = attackPower;
    }

    public void Attack(Character target)
    {
        Console.WriteLine(this.name + " attacks " + target.name + " for " + this.attackPower + " damage.");
        target.health -= this.attackPower;
    }

    public bool IsAlive()
    {
        return health > 0;
    }
}

class Player : Character
{
    public Player(string name, int health, int attackPower) : base(name, health, attackPower)
    {

    }

    public void Heal()
    {
        int healAmount = 20;
        health += healAmount;
        Console.WriteLine(this.name + " heals for " + healAmount + " HP.");
    }
}

class Enemy : Character
{
    public Enemy(string name, int health, int attackPower) : base(name, health, attackPower)
    {

    }

    public void Attack(Character target)
    {
        Console.WriteLine(this.name + " attacks " + target.name + " for " + this.attackPower + " damage.");
        target.health -= this.attackPower;
    }
}

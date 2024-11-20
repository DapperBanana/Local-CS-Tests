
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Player player = new Player("Warrior", 100, 20);
        Enemy enemy = new Enemy("Goblin", 50, 10);

        Console.WriteLine("A " + enemy.Name + " appears!");

        while (player.Health > 0 && enemy.Health > 0)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Player HP: " + player.Health);
            Console.WriteLine("Enemy HP: " + enemy.Health);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Choose your action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    player.Attack(enemy);
                    break;

                case 2:
                    player.Defend();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (enemy.Health > 0)
            {
                enemy.Attack(player);
            }

            Thread.Sleep(1000);
        }

        if (player.Health <= 0)
        {
            Console.WriteLine("You have been defeated. Game over.");
        }
        else
        {
            Console.WriteLine("Congratulations! You have defeated the " + enemy.Name + ".");
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
        this.Name = name;
        this.Health = health;
        this.AttackPower = attackPower;
    }

    public void Attack(Character target)
    {
        int damage = this.AttackPower;
        target.Health -= damage;
        Console.WriteLine(this.Name + " attacks " + target.Name + " for " + damage + " damage.");
    }

    public void Defend()
    {
        Console.WriteLine(this.Name + " defends and gains 5 HP.");
        this.Health += 5;
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

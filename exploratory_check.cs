
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Text-Based RPG Game");

        Player player = new Player();
        Enemy enemy = new Enemy();
        
        Console.WriteLine("You encounter an enemy!");
        
        while (player.IsAlive && enemy.IsAlive)
        {
            Console.WriteLine($"Player HP: {player.Health} --- Enemy HP: {enemy.Health}");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Run");

            string input = Console.ReadLine();

            if (input == "1")
            {
                player.Attack(enemy);
                if (enemy.IsAlive)
                {
                    enemy.Attack(player);
                }
            }
            else if (input == "2")
            {
                Console.WriteLine("You ran away from the enemy!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }

            Thread.Sleep(1000);
        }

        if (player.IsAlive)
        {
            Console.WriteLine("You defeated the enemy! Congrats!");
        }
        else
        {
            Console.WriteLine("Game over!");
        }
    }
}

class Player
{
    public int Health { get; set; }
    public bool IsAlive { get { return Health > 0; } }

    public Player()
    {
        Health = 100;
    }

    public void Attack(Enemy enemy)
    {
        Random rand = new Random();
        int damage = rand.Next(5, 11);
        Console.WriteLine($"You attack the enemy for {damage} damage!");
        enemy.TakeDamage(damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"You took {damage} damage!");
    }
}

class Enemy
{
    public int Health { get; set; }
    public bool IsAlive { get { return Health > 0; } }

    public Enemy()
    {
        Health = 50;
    }

    public void Attack(Player player)
    {
        Random rand = new Random();
        int damage = rand.Next(3, 8);
        Console.WriteLine($"Enemy attacks you for {damage} damage!");
        player.TakeDamage(damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"Enemy took {damage} damage!");
    }
}


using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Hero", 100, 10);
        Enemy enemy = new Enemy("Goblin", 50, 5);

        Console.WriteLine("A wild enemy appears: " + enemy.Name);

        while (player.IsAlive() && enemy.IsAlive())
        {
            Console.WriteLine("Player HP: " + player.HP + " Enemy HP: " + enemy.HP);
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    player.Attack(enemy);
                    if (enemy.IsAlive())
                    {
                        enemy.Attack(player);
                    }
                    break;
                case 2:
                    player.Heal();
                    enemy.Attack(player);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        if (player.IsAlive())
        {
            Console.WriteLine("Victory! The enemy is defeated.");
        }
        else
        {
            Console.WriteLine("Game Over! The player is defeated.");
        }
    }
}

class Player
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int AttackPower { get; set; }

    public Player(string name, int hp, int attackPower)
    {
        Name = name;
        HP = hp;
        AttackPower = attackPower;
    }

    public bool IsAlive()
    {
        return HP > 0;
    }

    public void Attack(Enemy enemy)
    {
        int damage = AttackPower;
        enemy.HP -= damage;
        Console.WriteLine("Player attacks the enemy for " + damage + " damage.");
    }

    public void Heal()
    {
        HP += 20;
        Console.WriteLine("Player heals for 20 HP.");
    }
}

class Enemy
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int AttackPower { get; set; }

    public Enemy(string name, int hp, int attackPower)
    {
        Name = name;
        HP = hp;
        AttackPower = attackPower;
    }

    public bool IsAlive()
    {
        return HP > 0;
    }

    public void Attack(Player player)
    {
        int damage = AttackPower;
        player.HP -= damage;
        Console.WriteLine("Enemy attacks the player for " + damage + " damage.");
    }
}

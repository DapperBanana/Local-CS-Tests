
using System;

class Program
{
    static void Main()
    {
        Player player = new Player("Hero", 100, 20);
        Enemy enemy = new Enemy("Goblin", 50, 10);

        Console.WriteLine("A wild " + enemy.Name + " appeared!");

        while (player.IsAlive() && enemy.IsAlive())
        {
            Console.WriteLine("Choose your action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                player.Attack(enemy);
            }
            else if (choice == 2)
            {
                player.Defend();
            }

            if (enemy.IsAlive())
            {
                enemy.Attack(player);
            }

            Console.WriteLine(player.Name + " HP: " + player.HP);
            Console.WriteLine(enemy.Name + " HP: " + enemy.HP);
        }

        if (player.IsAlive())
        {
            Console.WriteLine("You defeated the " + enemy.Name + "!");
        }
        else
        {
            Console.WriteLine("You were defeated by the " + enemy.Name + "!");
        }
    }
}

class Character
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int AttackPower { get; set; }
    public bool IsDefending { get; set; }

    public Character(string name, int hp, int attackPower)
    {
        Name = name;
        HP = hp;
        AttackPower = attackPower;
        IsDefending = false;
    }

    public bool IsAlive()
    {
        return HP > 0;
    }

    public void Attack(Character target)
    {
        int damage = IsDefending ? AttackPower / 2 : AttackPower;
        target.HP -= damage;

        Console.WriteLine(Name + " attacks " + target.Name + " for " + damage + " damage!");
    }

    public void Defend()
    {
        IsDefending = true;
        Console.WriteLine(Name + " is defending!");
    }
}

class Player : Character
{
    public Player(string name, int hp, int attackPower) : base(name, hp, attackPower)
    {

    }
}

class Enemy : Character
{
    public Enemy(string name, int hp, int attackPower) : base(name, hp, attackPower)
    {

    }
}

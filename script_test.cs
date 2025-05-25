
using System;

namespace TextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Text RPG game!");
            
            Player player = new Player("Hero", 100, 10);
            Enemy enemy = new Enemy("Goblin", 50, 5);
            
            Console.WriteLine($"You encounter a {enemy.Name}!");
            
            while(player.IsAlive() && enemy.IsAlive())
            {
                Console.WriteLine($"Player HP: {player.Health} | Enemy HP: {enemy.Health}");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Run away");
                
                int choice = Convert.ToInt32(Console.ReadLine());
                
                if(choice == 1)
                {
                    player.Attack(enemy);
                    if(enemy.IsAlive())
                    {
                        enemy.Attack(player);
                    }
                }
                else if(choice == 2)
                {
                    Console.WriteLine("You run away from the enemy!");
                    break;
                }
            }
            
            if(player.IsAlive())
            {
                Console.WriteLine("You defeated the enemy! You are victorious!");
            }
            else
            {
                Console.WriteLine("Game over! You have been defeated!");
            }
        }
    }
    
    class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public Player(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public void Attack(Enemy enemy)
        {
            int damageDealt = Damage;
            enemy.Health -= damageDealt;
            Console.WriteLine($"You attack the {enemy.Name} for {damageDealt} damage!");
        }

        public bool IsAlive()
        {
            return Health > 0;
        }
    }
    
    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public Enemy(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public void Attack(Player player)
        {
            int damageDealt = Damage;
            player.Health -= damageDealt;
            Console.WriteLine($"The {Name} attacks you for {damageDealt} damage!");
        }

        public bool IsAlive()
        {
            return Health > 0;
        }
    }
}

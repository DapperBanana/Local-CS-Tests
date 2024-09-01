
using System;

namespace TextBasedRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Text Based RPG Game!");

            Console.WriteLine("Choose a class:");
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Mage");
            Console.WriteLine("3. Archer");

            int playerClass = Convert.ToInt32(Console.ReadLine());

            Player player = new Player();

            switch (playerClass)
            {
                case 1:
                    player = new Warrior();
                    break;
                case 2:
                    player = new Mage();
                    break;
                case 3:
                    player = new Archer();
                    break;
                default:
                    Console.WriteLine("Invalid class choice. Defaulting to Warrior.");
                    player = new Warrior();
                    break;
            }

            Console.WriteLine($"You have chosen the {player.Class} class.");

            Console.WriteLine("Your adventure begins...");

            while (player.IsAlive)
            {
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Heal");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        player.Attack();
                        break;
                    case 2:
                        player.Heal();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }

            Console.WriteLine("Game over. You have been defeated.");
        }
    }

    class Player
    {
        public string Class { get; set; }
        public int Health { get; set; }
        public bool IsAlive { get; set; }

        public Player()
        {
            Health = 100;
            IsAlive = true;
        }

        public virtual void Attack()
        {
            Console.WriteLine("Player attacks!");
        }

        public virtual void Heal()
        {
            Console.WriteLine("Player heals.");
        }
    }

    class Warrior : Player
    {
        public Warrior()
        {
            Class = "Warrior";
            Health = 150;
        }

        public override void Attack()
        {
            Console.WriteLine("Warrior slashes with his sword!");
        }

        public override void Heal()
        {
            Console.WriteLine("Warrior drinks a health potion.");
        }
    }

    class Mage : Player
    {
        public Mage()
        {
            Class = "Mage";
            Health = 100;
        }

        public override void Attack()
        {
            Console.WriteLine("Mage casts a fireball!");
        }

        public override void Heal()
        {
            Console.WriteLine("Mage casts a healing spell.");
        }
    }

    class Archer : Player
    {
        public Archer()
        {
            Class = "Archer";
            Health = 120;
        }

        public override void Attack()
        {
            Console.WriteLine("Archer shoots an arrow!");
        }

        public override void Heal()
        {
            Console.WriteLine("Archer applies a bandage.");
        }
    }
}

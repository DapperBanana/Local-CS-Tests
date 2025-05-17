
using System;

class Card
{
    public string Name { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }

    public Card(string name, int attack, int defense)
    {
        Name = name;
        Attack = attack;
        Defense = defense;
    }
}

class Program
{
    static void Main()
    {
        Card playerCard = new Card("Warrior", 10, 5);
        Card enemyCard = new Card("Dragon", 15, 8);

        Console.WriteLine("Player Card: {0} ({1}/{2})", playerCard.Name, playerCard.Attack, playerCard.Defense);
        Console.WriteLine("Enemy Card: {0} ({1}/{2})", enemyCard.Name, enemyCard.Attack, enemyCard.Defense);

        Console.WriteLine("Press any key to start the battle...");
        Console.ReadKey();

        while (playerCard.Defense > 0 && enemyCard.Defense > 0)
        {
            // Player attacks enemy
            enemyCard.Defense -= playerCard.Attack;
            Console.WriteLine("Player attacks Enemy! Enemy's defense reduced to {0}", enemyCard.Defense);

            // Enemy attacks player
            playerCard.Defense -= enemyCard.Attack;
            Console.WriteLine("Enemy attacks Player! Player's defense reduced to {0}", playerCard.Defense);

            Console.WriteLine("Press any key to continue the battle...");
            Console.ReadKey();
        }

        if (playerCard.Defense <= 0)
        {
            Console.WriteLine("Player has been defeated! Game Over.");
        }
        else
        {
            Console.WriteLine("Player has defeated the Enemy! Victory!");
        }
    }
}

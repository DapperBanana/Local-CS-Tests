
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
        Card playerCard = new Card("Player Card", 10, 5);
        Card computerCard = new Card("Computer Card", 8, 7);

        Console.WriteLine("Player Card - Name: {0}, Attack: {1}, Defense: {2}", playerCard.Name, playerCard.Attack, playerCard.Defense);
        Console.WriteLine("Computer Card - Name: {0}, Attack: {1}, Defense: {2}", computerCard.Name, computerCard.Attack, computerCard.Defense);

        Console.WriteLine();

        if (playerCard.Attack > computerCard.Defense)
        {
            Console.WriteLine("Player wins!");
        }
        else if (playerCard.Attack < computerCard.Defense)
        {
            Console.WriteLine("Computer wins!");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
    }
}

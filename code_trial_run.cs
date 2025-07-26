
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Trading Card Game!");

        // Create player 1's card
        Card player1Card = new Card("Goblin", 10, 5);

        // Create player 2's card
        Card player2Card = new Card("Dragon", 20, 10);

        // Display the cards
        Console.WriteLine("Player 1's Card: ");
        player1Card.Display();
        Console.WriteLine();

        Console.WriteLine("Player 2's Card: ");
        player2Card.Display();
        Console.WriteLine();

        // Simulate a battle between the two cards
        while (player1Card.Health > 0 && player2Card.Health > 0)
        {
            player1Card.Attack(player2Card);
            if (player2Card.Health <= 0)
            {
                Console.WriteLine("Player 1 wins!");
                break;
            }

            player2Card.Attack(player1Card);
            if (player1Card.Health <= 0)
            {
                Console.WriteLine("Player 2 wins!");
                break;
            }
        }
    }
}

class Card
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int AttackPower { get; private set; }

    public Card(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Attack Power: {AttackPower}");
    }

    public void Attack(Card opponent)
    {
        Console.WriteLine($"{Name} attacks {opponent.Name} for {AttackPower} damage");
        opponent.Health -= AttackPower;
        Console.WriteLine($"{opponent.Name} health remaining: {opponent.Health}");
    }
}

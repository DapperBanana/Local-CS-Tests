
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the trading card game!");

        Player player1 = new Player("Player 1");
        Player player2 = new Player("Player 2");

        Console.WriteLine($"{player1.Name} vs {player2.Name}");

        // Initialize player 1's deck
        player1.AddCardToDeck(new Card("Warrior", 10, 5));
        player1.AddCardToDeck(new Card("Mage", 8, 7));
        player1.AddCardToDeck(new Card("Archer", 6, 9));

        // Initialize player 2's deck
        player2.AddCardToDeck(new Card("Warrior", 9, 4));
        player2.AddCardToDeck(new Card("Mage", 7, 8));
        player2.AddCardToDeck(new Card("Archer", 5, 10));

        while (player1.HasCardsRemaining() && player2.HasCardsRemaining())
        {
            Card player1Card = player1.DrawCard();
            Card player2Card = player2.DrawCard();

            Console.WriteLine($"{player1.Name} plays {player1Card.Name} (Attack: {player1Card.Attack}, Defense: {player1Card.Defense})");
            Console.WriteLine($"{player2.Name} plays {player2Card.Name} (Attack: {player2Card.Attack}, Defense: {player2Card.Defense})");

            if (player1Card.Attack > player2Card.Defense)
            {
                Console.WriteLine($"{player1.Name} wins this round!");
                player1.AddCardToDeck(player1Card);
                player1.AddCardToDeck(player2Card);
            }
            else if (player2Card.Attack > player1Card.Defense)
            {
                Console.WriteLine($"{player2.Name} wins this round!");
                player2.AddCardToDeck(player1Card);
                player2.AddCardToDeck(player2Card);
            }
            else
            {
                Console.WriteLine("It's a tie!");
                player1.AddCardToDeck(player1Card);
                player2.AddCardToDeck(player2Card);
            }
        }

        if (player1.HasCardsRemaining())
        {
            Console.WriteLine($"{player1.Name} wins the game!");
        }
        else
        {
            Console.WriteLine($"{player2.Name} wins the game!");
        }
    }
}

class Player
{
    public string Name { get; }
    private Queue<Card> deck;

    public Player(string name)
    {
        Name = name;
        deck = new Queue<Card>();
    }

    public void AddCardToDeck(Card card)
    {
        deck.Enqueue(card);
    }

    public Card DrawCard()
    {
        return deck.Dequeue();
    }

    public bool HasCardsRemaining()
    {
        return deck.Count > 0;
    }
}

class Card
{
    public string Name { get; }
    public int Attack { get; }
    public int Defense { get; }

    public Card(string name, int attack, int defense)
    {
        Name = name;
        Attack = attack;
        Defense = defense;
    }
}

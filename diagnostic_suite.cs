
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Trading Card Game!");

        Player player1 = new Player("Player 1");
        Player player2 = new Player("Player 2");

        Deck deck = new Deck();
        deck.Shuffle();

        Console.WriteLine("\nDealing cards to players...\n");

        for (int i = 0; i < 5; i++)
        {
            player1.DrawCard(deck);
            player2.DrawCard(deck);
        }

        player1.DisplayHand();
        player2.DisplayHand();

        Console.WriteLine("\nBegin the game!\n");

        while (player1.GetHandSize() > 0 && player2.GetHandSize() > 0)
        {
            Card player1Card = player1.PlayCard();
            Card player2Card = player2.PlayCard();

            Console.WriteLine($"Player 1 plays: {player1Card}");
            Console.WriteLine($"Player 2 plays: {player2Card}");

            if (player1Card.GetValue() > player2Card.GetValue())
            {
                Console.WriteLine("Player 1 wins the round!");
                player1.AddToScore();
            }
            else if (player2Card.GetValue() > player1Card.GetValue())
            {
                Console.WriteLine("Player 2 wins the round!");
                player2.AddToScore();
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }

            Console.WriteLine($"Score - Player 1: {player1.GetScore()} | Player 2: {player2.GetScore()}\n");

            Console.WriteLine("Press Enter to continue to the next round...");
            Console.ReadLine();
        }

        if (player1.GetScore() > player2.GetScore())
            Console.WriteLine("Player 1 wins the game!");
        else if (player2.GetScore() > player1.GetScore())
            Console.WriteLine("Player 2 wins the game!");
        else
            Console.WriteLine("It's a tie!");

        Console.WriteLine("\nGame over. Thanks for playing!");
    }
}

class Deck
{
    private Card[] cards;
    private int currentIndex;

    public Deck()
    {
        cards = new Card[20];
        currentIndex = 0;

        // Initialize the deck with cards
    }

    public void Shuffle()
    {
        // Shuffle the deck
    }

    public Card DrawCard()
    {
        Card drawnCard = cards[currentIndex];
        currentIndex++;
        return drawnCard;
    }
}

class Card
{
    private string name;
    private int value;

    public Card(string name, int value)
    {
        this.name = name;
        this.value = value;
    }

    public int GetValue()
    {
        return value;
    }

    public override string ToString()
    {
        return $"{name} ({value})";
    }
}

class Player
{
    private string name;
    private Card[] hand;
    private int handSize;
    private int score;

    public Player(string name)
    {
        this.name = name;
        hand = new Card[5];
        handSize = 0;
        score = 0;
    }

    public void DrawCard(Deck deck)
    {
        hand[handSize] = deck.DrawCard();
        handSize++;
    }

    public Card PlayCard()
    {
        Card playedCard = hand[0];
        // Shift cards in hand to the left
        for (int i = 0; i < handSize - 1; i++)
        {
            hand[i] = hand[i + 1];
        }
        handSize--;
        return playedCard;
    }

    public void AddToScore()
    {
        score++;
    }

    public int GetScore()
    {
        return score;
    }

    public int GetHandSize()
    {
        return handSize;
    }

    public void DisplayHand()
    {
        Console.WriteLine($"{name}'s hand:");
        for (int i = 0; i < handSize; i++)
        {
            Console.WriteLine($"{i + 1}. {hand[i]}");
        }
        Console.WriteLine();
    }
}

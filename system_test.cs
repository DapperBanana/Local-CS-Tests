
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Trading Card Game!");

        // Player setup
        Player player1 = new Player("Player 1");
        Player player2 = new Player("Player 2");

        player1.SetupDeck();
        player2.SetupDeck();

        // Game loop
        while (player1.IsAlive() && player2.IsAlive())
        {
            player1.DrawCard();
            player2.DrawCard();

            Console.WriteLine($"Player 1: {player1.GetHand()}");
            Console.WriteLine($"Player 2: {player2.GetHand()}");

            player1.PlayCard();
            player2.PlayCard();

            Console.WriteLine($"Player 1 HP: {player1.GetHP()}");
            Console.WriteLine($"Player 2 HP: {player2.GetHP()}");
        }

        // Game over
        if (player1.IsAlive())
        {
            Console.WriteLine("Player 1 wins!");
        }
        else
        {
            Console.WriteLine("Player 2 wins!");
        }
    }
}

class Player
{
    private string name;
    private int hp;
    private Deck deck;
    private Hand hand;

    public Player(string name)
    {
        this.name = name;
        this.hp = 30;
        this.deck = new Deck();
        this.hand = new Hand();
    }

    public void SetupDeck()
    {
        deck.AddCard(new Card("Card 1", 5));
        deck.AddCard(new Card("Card 2", 3));
        deck.AddCard(new Card("Card 3", 7));
    }

    public void DrawCard()
    {
        Card drawnCard = deck.Draw();
        hand.AddCard(drawnCard);
    }

    public void PlayCard()
    {
        Card cardToPlay = hand.Play();
        hp -= cardToPlay.GetDamage();
    }

    public bool IsAlive()
    {
        return hp > 0;
    }

    public string GetHand()
    {
        return hand.ToString();
    }

    public int GetHP()
    {
        return hp;
    }
}

class Deck
{
    private Card[] cards;
    private int top;

    public Deck()
    {
        cards = new Card[10];
        top = 0;
    }

    public void AddCard(Card card)
    {
        cards[top++] = card;
    }

    public Card Draw()
    {
        return cards[--top];
    }
}

class Hand
{
    private Card[] cards;
    private int top;

    public Hand()
    {
        cards = new Card[5];
        top = 0;
    }

    public void AddCard(Card card)
    {
        cards[top++] = card;
    }

    public Card Play()
    {
        return cards[--top];
    }

    public override string ToString()
    {
        string result = "";
        for (int i = 0; i < top; i++)
        {
            result += cards[i].ToString() + " ";
        }
        return result;
    }
}

class Card
{
    private string name;
    private int damage;

    public Card(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public int GetDamage()
    {
        return damage;
    }

    public override string ToString()
    {
        return $"{name} ({damage} damage)";
    }
}

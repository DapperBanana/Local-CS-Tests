
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Blackjack!");

        Deck deck = new Deck();
        deck.Shuffle();

        Hand playerHand = new Hand();
        Hand dealerHand = new Hand();

        playerHand.AddCard(deck.DrawCard());
        playerHand.AddCard(deck.DrawCard());

        dealerHand.AddCard(deck.DrawCard());
        dealerHand.AddCard(deck.DrawCard());

        Console.WriteLine("Your hand:");
        playerHand.DisplayHand();

        while (playerHand.CalculateHandValue() < 21)
        {
            Console.Write("Hit or Stand? (h/s): ");
            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (choice == 'h')
            {
                playerHand.AddCard(deck.DrawCard());
                playerHand.DisplayHand();
            }
            else if (choice == 's')
            {
                break;
            }
        }

        if (playerHand.CalculateHandValue() > 21)
        {
            Console.WriteLine("Bust! You lose.");
        }
        else
        {
            Console.WriteLine("Dealer's hand:");
            dealerHand.DisplayHand();

            while (dealerHand.CalculateHandValue() < 17)
            {
                dealerHand.AddCard(deck.DrawCard());
            }

            if (dealerHand.CalculateHandValue() > 21 || dealerHand.CalculateHandValue() < playerHand.CalculateHandValue())
            {
                Console.WriteLine("You win!");
            }
            else if (dealerHand.CalculateHandValue() > playerHand.CalculateHandValue())
            {
                Console.WriteLine("Dealer wins.");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }
}

class Deck
{
    private List<Card> cards;
    private Random random;

    public Deck()
    {
        cards = new List<Card>();
        random = new Random();

        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                cards.Add(new Card(rank, suit));
            }
        }
    }

    public void Shuffle()
    {
        for (int i = cards.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            Card temp = cards[i];
            cards[i] = cards[j];
            cards[j] = temp;
        }
    }

    public Card DrawCard()
    {
        Card card = cards[0];
        cards.RemoveAt(0);
        return card;
    }
}

class Card
{
    public Rank Rank { get; }
    public Suit Suit { get; }

    public Card(Rank rank, Suit suit)
    {
        Rank = rank;
        Suit = suit;
    }

    public int GetValue()
    {
        int value = (int)Rank;
        return (value > 10) ? 10 : value;
    }

    public override string ToString()
    {
        return $"{Rank} of {Suit}";
    }
}

class Hand
{
    private List<Card> cards;

    public Hand()
    {
        cards = new List<Card>();
    }

    public void AddCard(Card card)
    {
        cards.Add(card);
    }

    public int CalculateHandValue()
    {
        int value = 0;
        int numAces = 0;

        foreach (Card card in cards)
        {
            value += card.GetValue();
            if (card.Rank == Rank.Ace)
            {
                numAces++;
            }
        }

        while (value > 21 && numAces > 0)
        {
            value -= 10;
            numAces--;
        }

        return value;
    }

    public void DisplayHand()
    {
        foreach (Card card in cards)
        {
            Console.WriteLine(card);
        }

        Console.WriteLine("Total Value: " + CalculateHandValue());
    }
}

enum Suit
{
    Hearts,
    Diamonds,
    Clubs,
    Spades
}

enum Rank
{
    Ace = 1,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King
}

using System;
using System.Collections.Generic;

class Program
{
    static Random rand = new Random();

    static void Main()
    {
        Console.WriteLine("Welcome to the blackjack game!");

        bool playAgain = true;
        while (playAgain)
        {
            PlayGame();

            Console.WriteLine("Do you want to play again? (y/n)");
            string response = Console.ReadLine().Trim().ToLower();
            playAgain = response == "y" || response == "yes";
        }

        Console.WriteLine("Thanks for playing!");
    }

    static void PlayGame()
    {
        List<int> deck = CreateDeck();
        ShuffleDeck(deck);

        int playerScore = 0;
        int dealerScore = 0;

        // Deal initial two cards to player
        int playerCard1 = DrawCard(deck);
        int playerCard2 = DrawCard(deck);
        playerScore = GetCardValue(playerCard1) + GetCardValue(playerCard2);
        Console.WriteLine($"Your cards: {CardName(playerCard1)} and {CardName(playerCard2)} (Total: {playerScore})");

        // Deal initial two cards to dealer
        int dealerCard1 = DrawCard(deck);
        int dealerCard2 = DrawCard(deck);
        dealerScore = GetCardValue(dealerCard1) + GetCardValue(dealerCard2);
        Console.WriteLine($"Dealer shows: {CardName(dealerCard1)}");

        // Player's turn
        while (true)
        {
            Console.WriteLine("Do you want to hit or stand? (h/s)");
            string choice = Console.ReadLine().Trim().ToLower();
            if (choice == "h" || choice == "hit")
            {
                int newCard = DrawCard(deck);
                int newCardValue = GetCardValue(newCard);
                playerScore += newCardValue;
                Console.WriteLine($"You drew {CardName(newCard)}. Total: {playerScore}");

                if (playerScore > 21)
                {
                    Console.WriteLine("Bust! You exceeded 21. Dealer wins.");
                    return;
                }
            }
            else if (choice == "s" || choice == "stand")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'h' or 's'.");
            }
        }

        Console.WriteLine($"Dealer's hidden card was: {CardName(dealerCard2)} (Total: {dealerScore})");

        // Dealer's turn
        while (dealerScore < 17)
        {
            int newCard = DrawCard(deck);
            dealerScore += GetCardValue(newCard);
            Console.WriteLine($"Dealer draws {CardName(newCard)}. Total: {dealerScore}");
        }

        if (dealerScore > 21)
        {
            Console.WriteLine("Dealer busts! You win!");
            return;
        }

        // Determine winner
        Console.WriteLine($"Your total: {playerScore}, Dealer's total: {dealerScore}");
        if (playerScore > dealerScore)
        {
            Console.WriteLine("Congratulations! You win!");
        }
        else if (playerScore < dealerScore)
        {
            Console.WriteLine("Dealer wins! Better luck next time.");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
    }

    static List<int> CreateDeck()
    {
        List<int> deck = new List<int>();
        // Cards 2-10
        for (int i = 2; i <= 10; i++)
        {
            // Four suits, but suits don't matter here, so add four of each
            for (int j = 0; j < 4; j++)
            {
                deck.Add(i);
            }
        }
        // Face cards: Jack, Queen, King as 10
        for (int j = 0; j < 4 * 3; j++)
        {
            deck.Add(10);
        }
        // Aces as 11
        for (int j = 0; j < 4; j++)
        {
            deck.Add(11);
        }
        return deck;
    }

    static void ShuffleDeck(List<int> deck)
    {
        int n = deck.Count;
        for (int i = 0; i < n; i++)
        {
            int r = i + rand.Next(n - i);
            int temp = deck[r];
            deck[r] = deck[i];
            deck[i] = temp;
        }
    }

    static int DrawCard(List<int> deck)
    {
        if (deck.Count == 0)
        {
            deck = CreateDeck();
            ShuffleDeck(deck);
            Console.WriteLine("Deck reshuffled.");
        }
        int card = deck[0];
        deck.RemoveAt(0);
        return card;
    }

    static int GetCardValue(int card)
    {
        return card;
    }

    static string CardName(int card)
    {
        if (card == 11)
            return "Ace";
        else if (card == 10)
            return "10/Jack/Queen/King";
        else
            return card.ToString();
    }
}
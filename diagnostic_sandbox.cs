
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Blackjack!");

        // Initialize deck of cards
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 }; // Ace can be 11 or 1

        string[] deck = new string[52];
        int index = 0;

        foreach (string suit in suits)
        {
            foreach (string rank in ranks)
            {
                deck[index] = rank + " of " + suit;
                index++;
            }
        }

        // Shuffle deck
        Random rng = new Random();
        for (int i = deck.Length - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            string temp = deck[i];
            deck[i] = deck[j];
            deck[j] = temp;
        }

        // Deal initial cards to player and dealer
        int playerTotal = 0;
        int dealerTotal = 0;

        for (int i = 0; i < 2; i++)
        {
            playerTotal += values[Array.IndexOf(ranks, deck[i].Split(' ')[0])];
            dealerTotal += values[Array.IndexOf(ranks, deck[i + 2].Split(' ')[0])];
        }

        // Show player's cards
        Console.WriteLine("Your cards:");
        Console.WriteLine(deck[0]);
        Console.WriteLine(deck[1]);
        Console.WriteLine("Total: " + playerTotal);

        // Show dealer's cards
        Console.WriteLine("Dealer's cards:");
        Console.WriteLine(deck[2]);
        Console.WriteLine("Total: " + dealerTotal);

        // Player's turn
        bool playerBusted = false;
        while (playerTotal < 21)
        {
            Console.WriteLine("Hit or Stand? (h/s)");
            string choice = Console.ReadLine().ToLower();

            if (choice == "h")
            {
                playerTotal += values[Array.IndexOf(ranks, deck[index].Split(' ')[0])];
                Console.WriteLine(deck[index]);
                Console.WriteLine("Total: " + playerTotal);
                index++;
            }
            else if (choice == "s")
            {
                break;
            }

            if (playerTotal > 21)
            {
                playerBusted = true;
                break;
            }
        }

        // Dealer's turn
        bool dealerBusted = false;
        while (dealerTotal < 17)
        {
            dealerTotal += values[Array.IndexOf(ranks, deck[index].Split(' ')[0])];
            Console.WriteLine(deck[index]);
            Console.WriteLine("Total: " + dealerTotal);
            index++;

            if (dealerTotal > 21)
            {
                dealerBusted = true;
                break;
            }
        }

        // Determine winner
        if (playerBusted)
        {
            Console.WriteLine("Player busts! Dealer wins.");
        }
        else if (dealerBusted)
        {
            Console.WriteLine("Dealer busts! Player wins.");
        }
        else if (playerTotal == dealerTotal)
        {
            Console.WriteLine("It's a tie!");
        }
        else if (playerTotal > dealerTotal)
        {
            Console.WriteLine("Player wins!");
        }
        else
        {
            Console.WriteLine("Dealer wins.");
        }
    }
}

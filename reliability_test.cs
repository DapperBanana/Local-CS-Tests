
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Trading Card Game!");

        List<Card> playerCards = new List<Card>();
        List<Card> computerCards = new List<Card>();

        // Generate player cards
        for (int i = 0; i < 3; i++)
        {
            Card newCard = new Card();
            playerCards.Add(newCard);
        }

        // Generate computer cards
        for (int i = 0; i < 3; i++)
        {
            Card newCard = new Card();
            computerCards.Add(newCard);
        }

        while (playerCards.Count > 0 && computerCards.Count > 0)
        {
            Console.WriteLine("Player cards:");
            ShowCards(playerCards);

            Console.WriteLine("\nComputer cards:");
            ShowCards(computerCards);

            Console.WriteLine("\nSelect a card to play (0, 1, 2):");
            int playerChoice = Convert.ToInt32(Console.ReadLine());

            Card playerCard = playerCards[playerChoice];

            Random rnd = new Random();
            int computerChoice = rnd.Next(0, computerCards.Count);
            Card computerCard = computerCards[computerChoice];

            Console.WriteLine($"\nPlayer plays: {playerCard.Name}");
            Console.WriteLine($"Computer plays: {computerCard.Name}");

            if (playerCard.Power > computerCard.Power)
            {
                Console.WriteLine("Player wins this round!");
                computerCards.RemoveAt(computerChoice);
            }
            else if (playerCard.Power < computerCard.Power)
            {
                Console.WriteLine("Computer wins this round!");
                playerCards.RemoveAt(playerChoice);
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        if (playerCards.Count == 0)
        {
            Console.WriteLine("Computer wins the game!");
        }
        else
        {
            Console.WriteLine("Player wins the game!");
        }

    }

    static void ShowCards(List<Card> cards)
    {
        for (int i = 0; i < cards.Count; i++)
        {
            Console.WriteLine($"{i}. {cards[i].Name} - Power: {cards[i].Power}");
        }
    }
}

public class Card
{
    public string Name { get; set; }
    public int Power { get; set; }

    public Card()
    {
        Random rnd = new Random();
        Name = "Card" + rnd.Next(1, 100);
        Power = rnd.Next(1, 10);
    }
}

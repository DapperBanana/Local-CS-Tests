
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Blackjack!");

        Random random = new Random();
        int playerTotal = 0;
        int dealerTotal = 0;

        // Player's initial hand
        int card1 = random.Next(1, 11);
        int card2 = random.Next(1, 11);
        playerTotal = card1 + card2;
        Console.WriteLine($"Your cards: {card1}, {card2}");
        Console.WriteLine($"Your total: {playerTotal}");

        // Dealer's initial hand
        int dealerCard1 = random.Next(1, 11);
        int dealerCard2 = random.Next(1, 11);
        dealerTotal = dealerCard1 + dealerCard2;
        Console.WriteLine($"Dealer's cards: {dealerCard1}, ?");

        // Player's turn
        while (playerTotal < 21)
        {
            Console.Write("Do you want to hit? (y/n): ");
            string input = Console.ReadLine();
            if (input == "y")
            {
                int newCard = random.Next(1, 11);
                playerTotal += newCard;
                Console.WriteLine($"You drew: {newCard}");
                Console.WriteLine($"Your total: {playerTotal}");
            }
            else if (input == "n")
            {
                break;
            }
        }

        // Dealer's turn
        Console.WriteLine($"Dealer's second card: {dealerCard2}");
        while (dealerTotal < 17)
        {
            int newCard = random.Next(1, 11);
            dealerTotal += newCard;
            Console.WriteLine($"Dealer drew: {newCard}");
            Console.WriteLine($"Dealer's total: {dealerTotal}");
        }

        // Display results
        Console.WriteLine($"Your total: {playerTotal}");
        Console.WriteLine($"Dealer's total: {dealerTotal}");

        if (playerTotal > 21)
        {
            Console.WriteLine("You bust! Dealer wins.");
        }
        else if (dealerTotal > 21 || playerTotal > dealerTotal)
        {
            Console.WriteLine("You win!");
        }
        else if (playerTotal == dealerTotal)
        {
            Console.WriteLine("It's a tie!");
        }
        else
        {
            Console.WriteLine("Dealer wins.");
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int playerScore = 0;
        int dealerScore = 0;

        Console.WriteLine("Welcome to Blackjack!");

        // Deal cards to player
        int card1 = rand.Next(1, 11);
        int card2 = rand.Next(1, 11);
        playerScore = card1 + card2;
        Console.WriteLine($"You have been dealt {card1} and {card2} (total: {playerScore})");

        // Deal cards to dealer
        card1 = rand.Next(1, 11);
        card2 = rand.Next(1, 11);
        dealerScore = card1 + card2;
        Console.WriteLine($"The dealer has been dealt {card1} and {card2} (total: {dealerScore})");
        
        // Player's turn
        while (playerScore < 21)
        {
            Console.Write("Do you want to hit or stand? (h/s): ");
            char choice = char.ToLower(Console.ReadKey().KeyChar);
            if (choice == 'h')
            {
                int card = rand.Next(1, 11);
                playerScore += card;
                Console.WriteLine($"\nYou drew a {card} (total: {playerScore})");
            }
            else if (choice == 's')
            {
                break;
            }
        }

        // Dealer's turn
        while (dealerScore < 17)
        {
            int card = rand.Next(1, 11);
            dealerScore += card;
            Console.WriteLine($"The dealer drew a {card} (total: {dealerScore})");
        }

        // Determine winner
        if (playerScore > 21)
        {
            Console.WriteLine("Player busts, dealer wins!");
        }
        else if (dealerScore > 21)
        {
            Console.WriteLine("Dealer busts, player wins!");
        }
        else if (playerScore == dealerScore)
        {
            Console.WriteLine("It's a tie!");
        }
        else if (playerScore > dealerScore)
        {
            Console.WriteLine("Player wins!");
        }
        else
        {
            Console.WriteLine("Dealer wins!");
        }
    }
}

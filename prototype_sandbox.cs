
using System;

namespace BlackjackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack!");

            Random rand = new Random();

            int playerTotal = 0;
            int dealerTotal = 0;

            // Player's turn
            while (playerTotal <= 21)
            {
                Console.WriteLine("Your current total is: " + playerTotal);
                Console.Write("Do you want to hit? (y/n): ");
                char choice = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (choice == 'y')
                {
                    int card = rand.Next(1, 11);
                    Console.WriteLine("You drew a " + card);
                    playerTotal += card;
                }
                else if (choice == 'n')
                {
                    break;
                }
            }

            // Dealer's turn
            while(dealerTotal <= 17)
            {
                int card = rand.Next(1, 11);
                dealerTotal += card;
            }

            Console.WriteLine("Dealer's total is: " + dealerTotal);

            // Determine winner
            if (playerTotal > 21)
            {
                Console.WriteLine("Bust! Dealer wins.");
            }
            else if (dealerTotal > 21)
            {
                Console.WriteLine("Dealer busts! You win.");
            }
            else if (playerTotal > dealerTotal)
            {
                Console.WriteLine("You win!");
            }
            else if (playerTotal < dealerTotal)
            {
                Console.WriteLine("Dealer wins.");
            }
            else
            {
                Console.WriteLine("It's a tie.");
            }
        }
    }
}

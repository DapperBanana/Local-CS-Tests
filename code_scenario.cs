
using System;

namespace BlackjackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack!");

            Random random = new Random();
            int playerTotal = 0;
            int dealerTotal = random.Next(16, 26);

            Console.WriteLine("Dealer's card: " + dealerTotal);

            while (playerTotal <= 21)
            {
                Console.WriteLine("Your total: " + playerTotal);

                Console.Write("Do you want to hit or stand? (h/s): ");
                string choice = Console.ReadLine();

                if (choice == "h")
                {
                    int card = random.Next(1, 11);
                    playerTotal += card;
                    Console.WriteLine("You drew a " + card);
                }
                else if (choice == "s")
                {
                    break;
                }

                if (playerTotal > 21)
                {
                    Console.WriteLine("Bust! You went over 21.");
                    break;
                }
            }

            Console.WriteLine("Your total: " + playerTotal);
            Console.WriteLine("Dealer's total: " + dealerTotal);

            if (playerTotal > 21 || dealerTotal == 21 || (dealerTotal > playerTotal && dealerTotal <= 21)) 
            {
                Console.WriteLine("Dealer wins!");
            }
            else if (playerTotal == dealerTotal)
            {
                Console.WriteLine("It's a tie!");
            }
            else
            {
                Console.WriteLine("You win!");
            }
        }
    }
}

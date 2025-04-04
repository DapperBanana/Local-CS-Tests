
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
            int dealerTotal = 0;

            while (true)
            {
                Console.WriteLine("Your total: " + playerTotal);
                Console.WriteLine("Dealer's total: " + dealerTotal);
                Console.WriteLine("Press 'h' to hit or 's' to stand.");

                string input = Console.ReadLine();
                if (input == "h")
                {
                    int card = random.Next(1, 11);
                    playerTotal += card;
                    Console.WriteLine("You drew a " + card);
                    
                    if (playerTotal > 21)
                    {
                        Console.WriteLine("Bust! Dealer wins.");
                        break;
                    }
                }
                else if (input == "s")
                {
                    while (dealerTotal < 17)
                    {
                        int card = random.Next(1, 11);
                        dealerTotal += card;
                        Console.WriteLine("Dealer drew a " + card);
                    }

                    if (dealerTotal > 21 || dealerTotal < playerTotal)
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (dealerTotal > playerTotal)
                    {
                        Console.WriteLine("Dealer wins.");
                    }
                    else
                    {
                        Console.WriteLine("It's a tie.");
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }
    }
}

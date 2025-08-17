
using System;

namespace BlackjackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack!");

            Random random = new Random();
            int playerTotal = random.Next(17, 22);
            int dealerTotal = random.Next(17, 22);

            Console.WriteLine("Your total is: " + playerTotal);
            Console.WriteLine("Dealer's total is: " + dealerTotal);

            if (playerTotal > dealerTotal && playerTotal <= 21)
            {
                Console.WriteLine("You win!");
            }
            else if (dealerTotal > playerTotal && dealerTotal <= 21)
            {
                Console.WriteLine("Dealer wins!");
            }
            else if (playerTotal > 21)
            {
                Console.WriteLine("You bust, dealer wins!");
            }
            else if (dealerTotal > 21)
            {
                Console.WriteLine("Dealer busts, you win!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }
}

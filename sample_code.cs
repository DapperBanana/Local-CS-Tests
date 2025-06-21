
using System;

namespace BlackjackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playerScore = 0;
            int dealerScore = 0;

            Console.WriteLine("Welcome to Blackjack!");

            playerScore += random.Next(1, 11) + random.Next(1, 11);
            dealerScore += random.Next(1, 11);

            Console.WriteLine("Your score: " + playerScore);
            Console.WriteLine("Dealer's score: " + dealerScore);

            while (playerScore < 21)
            {
                Console.WriteLine("Do you want to hit or stand? (h/s)");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice == 'h')
                {
                    playerScore += random.Next(1, 11);
                    Console.WriteLine("Your score: " + playerScore);

                    if (playerScore > 21)
                    {
                        Console.WriteLine("Bust! Dealer wins.");
                        return;
                    }
                }
                else if (choice == 's')
                {
                    break;
                }
            }

            while (dealerScore < 17)
            {
                dealerScore += random.Next(1, 11);
                Console.WriteLine("Dealer's score: " + dealerScore);
            }

            if (dealerScore > 21)
            {
                Console.WriteLine("Dealer busts! You win.");
            }
            else if (playerScore > dealerScore)
            {
                Console.WriteLine("You win!");
            }
            else if (playerScore < dealerScore)
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

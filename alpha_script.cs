
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

            playerTotal += DrawCard(random, "Player");
            dealerTotal += DrawCard(random, "Dealer");

            playerTotal += DrawCard(random, "Player");
            dealerTotal += DrawCard(random, "Dealer");

            bool playerTurn = true;
            while (playerTurn)
            {
                Console.WriteLine("Player total: " + playerTotal);
                Console.WriteLine("Dealer total: " + dealerTotal);

                Console.WriteLine("Do you want to hit or stand? (h/s)");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice == 'h')
                {
                    playerTotal += DrawCard(random, "Player");
                    if (playerTotal > 21)
                    {
                        Console.WriteLine("Player busts! Dealer wins.");
                        return;
                    }
                }
                else if (choice == 's')
                {
                    playerTurn = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }

            while (dealerTotal < 17)
            {
                dealerTotal += DrawCard(random, "Dealer");
            }

            Console.WriteLine("Player total: " + playerTotal);
            Console.WriteLine("Dealer total: " + dealerTotal);

            if (dealerTotal > 21 || playerTotal > dealerTotal)
            {
                Console.WriteLine("Player wins!");
            }
            else if (dealerTotal > playerTotal)
            {
                Console.WriteLine("Dealer wins.");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }

        static int DrawCard(Random random, string playerName)
        {
            int cardValue = random.Next(1, 14);
            if (cardValue > 10)
            {
                cardValue = 10;
            }
            Console.WriteLine(playerName + " draws a " + cardValue);
            return cardValue;
        }
    }
}

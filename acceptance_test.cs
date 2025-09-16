
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

            // Initial deal
            int card1 = random.Next(1, 11);
            int card2 = random.Next(1, 11);

            playerTotal += card1 + card2;
            Console.WriteLine($"You received a {card1} and a {card2}. Your total is {playerTotal}");

            // Player's turn
            while (playerTotal < 21)
            {
                Console.Write("Do you want to hit or stand? (h/s): ");
                string choice = Console.ReadLine();

                if (choice == "h")
                {
                    int newCard = random.Next(1, 11);
                    playerTotal += newCard;
                    Console.WriteLine($"You received a new card: {newCard}. Your total is {playerTotal}");
                }
                else if (choice == "s")
                {
                    break;
                }
            }

            // Dealer's turn
            int dealerCard1 = random.Next(1, 11);
            int dealerCard2 = random.Next(1, 11);

            dealerTotal += dealerCard1 + dealerCard2;
            Console.WriteLine($"Dealer received a {dealerCard1} and a {dealerCard2}. Dealer's total is {dealerTotal}");

            while (dealerTotal < 17)
            {
                int newDealerCard = random.Next(1, 11);
                dealerTotal += newDealerCard;
                Console.WriteLine($"Dealer received a new card: {newDealerCard}. Dealer's total is {dealerTotal}");
            }

            // Determine winner
            if (playerTotal <= 21 && (playerTotal > dealerTotal || dealerTotal > 21))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Dealer wins.");
            }

            Console.WriteLine($"Your total: {playerTotal}");
            Console.WriteLine($"Dealer's total: {dealerTotal}");
        }
    }
}

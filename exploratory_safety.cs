
using System;

namespace BlackjackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack!");

            // Initialize the deck
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };
            Random random = new Random();

            // Game loop
            while (true)
            {
                int playerScore = 0;
                int dealerScore = 0;

                // Deal cards to player and dealer
                playerScore += DealCard(suits, ranks, values, random);
                playerScore += DealCard(suits, ranks, values, random);
                dealerScore += DealCard(suits, ranks, values, random);
                dealerScore += DealCard(suits, ranks, values, random);

                Console.WriteLine($"Your hand: {playerScore}");
                Console.WriteLine($"Dealer's hand: {dealerScore}");

                // Player's turn
                while (playerScore < 21)
                {
                    Console.WriteLine("Hit or Stand? (h/s)");
                    string choice = Console.ReadLine();

                    if (choice.ToLower() == "h")
                    {
                        playerScore += DealCard(suits, ranks, values, random);
                        Console.WriteLine($"Your hand: {playerScore}");

                        if (playerScore > 21)
                        {
                            Console.WriteLine("Bust! You lose.");
                            break;
                        }
                    }
                    else if (choice.ToLower() == "s")
                    {
                        break;
                    }
                }

                // Dealer's turn
                while (dealerScore < 17)
                {
                    dealerScore += DealCard(suits, ranks, values, random);
                }

                Console.WriteLine($"Your hand: {playerScore}");
                Console.WriteLine($"Dealer's hand: {dealerScore}");

                // Compare scores
                if (playerScore <= 21 && (dealerScore > 21 || playerScore > dealerScore))
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("Dealer wins!");
                }

                // Ask to play again
                Console.WriteLine("Play again? (y/n)");
                string playAgain = Console.ReadLine();

                if (playAgain.ToLower() != "y")
                {
                    break;
                }
            }
        }

        static int DealCard(string[] suits, string[] ranks, int[] values, Random random)
        {
            int randomIndex = random.Next(suits.Length);
            Console.WriteLine($"Dealing {ranks[randomIndex]} of {suits[randomIndex]}");
            return values[randomIndex];
        }
    }
}

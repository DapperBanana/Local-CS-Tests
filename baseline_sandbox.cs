
using System;

namespace TextBasedBlackjackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Text-Based Blackjack Game!");

            while (true)
            {
                Random random = new Random();
                int playerTotal = 0;
                int dealerTotal = random.Next(16, 22);

                playerTotal += random.Next(1, 12);
                playerTotal += random.Next(1, 12);

                Console.WriteLine($"You have been dealt {playerTotal}");

                while (playerTotal < 21)
                {
                    Console.WriteLine("Do you want to Hit (H) or Stand (S)?");
                    string choice = Console.ReadLine();

                    if (choice.ToUpper() == "H")
                    {
                        int card = random.Next(1, 12);
                        playerTotal += card;
                        Console.WriteLine($"You have been dealt {card}. Your total is {playerTotal}");
                    }
                    else if (choice.ToUpper() == "S")
                    {
                        break;
                    }
                }

                if (playerTotal > 21)
                {
                    Console.WriteLine("Bust! Dealer wins.");
                }
                else
                {
                    Console.WriteLine($"Dealer has {dealerTotal}");

                    if (dealerTotal > playerTotal && dealerTotal <= 21)
                    {
                        Console.WriteLine("Dealer wins.");
                    }
                    else
                    {
                        Console.WriteLine("Player wins!");
                    }
                }

                Console.WriteLine("Do you want to play again? (Y/N)");
                string playAgain = Console.ReadLine();
                if (playAgain.ToUpper() != "Y")
                {
                    break;
                }
            }

            Console.WriteLine("Thank you for playing!");
        }
    }
}

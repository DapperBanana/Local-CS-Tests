
using System;

namespace BlackjackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playerTotal = 0;
            int dealerTotal = random.Next(17, 22);

            Console.WriteLine("Welcome to Blackjack!");

            while (true)
            {
                Console.WriteLine($"Your total: {playerTotal}");
                Console.WriteLine($"Dealer's total: {dealerTotal}");

                if (playerTotal > 21)
                {
                    Console.WriteLine("Bust! Dealer wins.");
                    break;
                }
                else if (playerTotal == 21)
                {
                    Console.WriteLine("Blackjack! You win!");
                    break;
                }

                Console.WriteLine("Do you want to (h)it or (s)tand?");
                string choice = Console.ReadLine();

                if (choice == "h")
                {
                    int card = random.Next(1, 11);
                    playerTotal += card;
                    Console.WriteLine($"You drew a {card}.");

                    if (playerTotal > 21)
                    {
                        Console.WriteLine($"Your total: {playerTotal}");
                        Console.WriteLine("Bust! Dealer wins.");
                        break;
                    }
                }
                else if (choice == "s")
                {
                    Console.WriteLine("You stand.");
                    Console.WriteLine($"Your total: {playerTotal}");

                    while (dealerTotal < 17)
                    {
                        int card = random.Next(1, 11);
                        dealerTotal += card;
                        Console.WriteLine($"Dealer drew a {card}.");
                    }

                    Console.WriteLine($"Dealer's total: {dealerTotal}");

                    if (dealerTotal > 21 || playerTotal > dealerTotal)
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (playerTotal < dealerTotal)
                    {
                        Console.WriteLine("Dealer wins.");
                    }
                    else
                    {
                        Console.WriteLine("It's a tie!");
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 'h' to hit or 's' to stand.");
                }
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}

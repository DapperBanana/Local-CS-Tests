
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Blackjack!");

        Random rand = new Random();
        int playerTotal = 0;
        int dealerTotal = rand.Next(16, 22);

        while (playerTotal < 21)
        {
            Console.WriteLine("Your total: " + playerTotal);
            Console.Write("Do you want to hit or stand? (h/s): ");
            char choice = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (choice == 'h')
            {
                int card = rand.Next(2, 12);
                Console.WriteLine("You drew a " + card);
                playerTotal += card;
            }
            else if (choice == 's')
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            if (playerTotal > 21)
            {
                Console.WriteLine("Bust! You lose.");
                return;
            }
        }

        Console.WriteLine("Your total: " + playerTotal);
        Console.WriteLine("Dealer total: " + dealerTotal);

        while (dealerTotal < 17)
        {
            int card = rand.Next(2, 12);
            Console.WriteLine("Dealer drew a " + card);
            dealerTotal += card;
        }

        if (dealerTotal > 21 || playerTotal > dealerTotal)
        {
            Console.WriteLine("You win!");
        }
        else if (playerTotal == dealerTotal)
        {
            Console.WriteLine("It's a tie!");
        }
        else
        {
            Console.WriteLine("Dealer wins.");
        }
    }
}

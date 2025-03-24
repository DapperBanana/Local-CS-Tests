
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int playerScore = 0;
        int dealerScore = 0;

        Console.WriteLine("Welcome to Blackjack!");

        while (true)
        {
            Console.WriteLine("Press any key to draw a card.");
            Console.ReadKey();

            int playerCard = random.Next(1, 11);
            playerScore += playerCard;
            Console.WriteLine($"You drew a {playerCard}. Your score is: {playerScore}");

            if (playerScore > 21)
            {
                Console.WriteLine("Bust! You lose.");
                break;
            }

            if (playerScore == 21)
            {
                Console.WriteLine("Blackjack! You win!");
                break;
            }

            int dealerCard = random.Next(1, 11);
            dealerScore += dealerCard;
            Console.WriteLine($"Dealer drew a {dealerCard}. Dealer's score is: {dealerScore}");

            if (dealerScore > 21)
            {
                Console.WriteLine("Dealer busts! You win!");
                break;
            }

            if (dealerScore >= 17)
            {
                if (dealerScore > playerScore)
                {
                    Console.WriteLine("Dealer wins.");
                }
                else if (dealerScore < playerScore)
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }
                break;
            }
        }

        Console.WriteLine("Game over. Thanks for playing!");
    }
}


using System;

class Program
{
    static void Main()
    {
        string[] choices = { "rock", "paper", "scissors" };
        Random rand = new Random();

        Console.WriteLine("Welcome to Rock-Paper-Scissors Game!");

        while (true)
        {
            // Get player's choice
            Console.Write("Enter your choice (rock, paper, scissors): ");
            string playerChoice = Console.ReadLine().ToLower();
            if (Array.IndexOf(choices, playerChoice) == -1)
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }

            // Generate computer's choice
            int computerChoiceIndex = rand.Next(3);
            string computerChoice = choices[computerChoiceIndex];

            // Display choices
            Console.WriteLine($"Computer picked: {computerChoice}");

            // Determine the winner
            if (playerChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((playerChoice == "rock" && computerChoice == "scissors") ||
                     (playerChoice == "paper" && computerChoice == "rock") ||
                     (playerChoice == "scissors" && computerChoice == "paper"))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }

            // Ask if the player wants to play again
            Console.Write("Play again? (y/n): ");
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain != "y")
            {
                break;
            }
        }
    }
}

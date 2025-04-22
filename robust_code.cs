
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        string[] choices = { "rock", "paper", "scissors" };

        Console.WriteLine("Welcome to Rock-Paper-Scissors game!");

        while (true)
        {
            // Get user's choice
            Console.Write("Enter your choice (rock, paper, or scissors): ");
            string userChoice = Console.ReadLine().ToLower();

            if (userChoice != "rock" && userChoice != "paper" && userChoice != "scissors")
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }

            // Generate computer's choice
            int computerIndex = random.Next(choices.Length);
            string computerChoice = choices[computerIndex];

            Console.WriteLine($"Computer chooses {computerChoice}");

            // Determine the winner
            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((userChoice == "rock" && computerChoice == "scissors")
                || (userChoice == "paper" && computerChoice == "rock")
                || (userChoice == "scissors" && computerChoice == "paper"))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }

            // Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string playAgain = Console.ReadLine().ToLower();

            if (playAgain != "yes")
            {
                break;
            }
        }
    }
}

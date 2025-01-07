
using System;

class Program
{
    static void Main()
    {
        string[] choices = { "rock", "paper", "scissors" };
        Random random = new Random();

        Console.WriteLine("Welcome to Rock-Paper-Scissors game!");

        while (true)
        {
            Console.WriteLine("\nEnter your choice (rock, paper, scissors): ");
            string userChoice = Console.ReadLine().ToLower();

            if (userChoice != "rock" && userChoice != "paper" && userChoice != "scissors")
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }

            int computerIndex = random.Next(choices.Length);
            string computerChoice = choices[computerIndex];

            Console.WriteLine($"Computer chooses: {computerChoice}");

            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((userChoice == "rock" && computerChoice == "scissors") ||
                     (userChoice == "paper" && computerChoice == "rock") ||
                     (userChoice == "scissors" && computerChoice == "paper"))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }

            Console.WriteLine("Play again? (yes/no)");
            string playAgain = Console.ReadLine().ToLower();

            if (playAgain != "yes")
            {
                Console.WriteLine("Thanks for playing. Goodbye!");
                break;
            }
        }
    }
}

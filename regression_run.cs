
using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors!");
            while (true)
            {
                Console.WriteLine("Enter your choice (rock, paper, or scissors): ");
                string playerChoice = Console.ReadLine().ToLower();

                if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                Random random = new Random();
                int computerChoice = random.Next(1, 4); // 1 for rock, 2 for paper, 3 for scissors
                string computerChoiceString = "";

                if (computerChoice == 1)
                {
                    computerChoiceString = "rock";
                }
                else if (computerChoice == 2)
                {
                    computerChoiceString = "paper";
                }
                else
                {
                    computerChoiceString = "scissors";
                }

                Console.WriteLine("Computer chose: " + computerChoiceString);

                if (playerChoice == computerChoiceString)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if ((playerChoice == "rock" && computerChoiceString == "scissors") ||
                         (playerChoice == "paper" && computerChoiceString == "rock") ||
                         (playerChoice == "scissors" && computerChoiceString == "paper"))
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("Computer wins!");
                }

                Console.WriteLine("Play again? (yes or no): ");
                string playAgain = Console.ReadLine().ToLower();

                if (playAgain != "yes")
                {
                    break;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}

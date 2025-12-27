using System;

class RockPaperScissors
{
    static void Main()
    {
        string[] options = { "rock", "paper", "scissors" };
        Random random = new Random();
        Console.WriteLine("Welcome to Rock-Paper-Scissors!");

        while (true)
        {
            Console.Write("Enter your choice (rock, paper, scissors) or 'exit' to quit: ");
            string userChoice = Console.ReadLine().ToLower();

            if (userChoice == "exit")
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }

            if (!Array.Exists(options, element => element == userChoice))
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }

            int computerIndex = random.Next(options.Length);
            string computerChoice = options[computerIndex];

            Console.WriteLine($"Computer chose: {computerChoice}");

            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a draw!");
            }
            else if (
                (userChoice == "rock" && computerChoice == "scissors") ||
                (userChoice == "scissors" && computerChoice == "paper") ||
                (userChoice == "paper" && computerChoice == "rock")
            )
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

            Console.WriteLine();
        }
    }
}
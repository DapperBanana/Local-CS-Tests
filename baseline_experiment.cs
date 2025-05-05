
using System;

class Program
{
    static void Main()
    {
        string[] choices = { "rock", "paper", "scissors" };

        Random random = new Random();

        Console.WriteLine("Let's play Rock, Paper, Scissors!");
        
        while (true)
        {
            Console.WriteLine("Enter your choice (rock, paper, or scissors):");
            string userChoice = Console.ReadLine().ToLower();
            int computerChoiceIndex = random.Next(choices.Length);
            string computerChoice = choices[computerChoiceIndex];
            
            Console.WriteLine("Computer chose: " + computerChoice);

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
                Console.WriteLine("Thanks for playing!");
                break;
            }
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        string[] options = { "rock", "paper", "scissors" };
        Random random = new Random();
        
        while (true)
        {
            // User's choice
            Console.WriteLine("Choose rock, paper, or scissors (or q to quit):");
            string userChoice = Console.ReadLine().ToLower();
            
            if (userChoice == "q")
            {
                break;
            }
            
            // Computer's choice
            int computerChoiceIndex = random.Next(0, 3);
            string computerChoice = options[computerChoiceIndex];
            
            // Determine winner
            Console.WriteLine($"Computer chose: {computerChoice}");
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
            
            Console.WriteLine();
        }
    }
}

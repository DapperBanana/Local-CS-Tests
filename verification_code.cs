
using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        string[] choices = { "rock", "paper", "scissors" };

        // Computer's choice
        int computerChoice = rand.Next(0, 3);
        string computerSelection = choices[computerChoice];

        // Player's choice
        Console.WriteLine("Choose rock, paper, or scissors:");
        string playerSelection = Console.ReadLine().ToLower();

        // Determine winner
        if (playerSelection == computerSelection)
        {
            Console.WriteLine("It's a tie! You both chose " + computerSelection + ".");
        }
        else if ((playerSelection == "rock" && computerSelection == "scissors") || 
                 (playerSelection == "paper" && computerSelection == "rock") || 
                 (playerSelection == "scissors" && computerSelection == "paper"))
        {
            Console.WriteLine("You win! Computer chose " + computerSelection + ".");
        }
        else
        {
            Console.WriteLine("You lose! Computer chose " + computerSelection + ".");
        }
    }
}

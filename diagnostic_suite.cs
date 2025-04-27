
using System;

class Program
{
    static void Main()
    {
        string[] choices = { "rock", "paper", "scissors" };
        
        // Generate a random choice for the computer
        Random random = new Random();
        int index = random.Next(choices.Length);
        string computerChoice = choices[index];

        Console.WriteLine("Choose: rock, paper, or scissors");
        string userChoice = Console.ReadLine().ToLower();

        Console.WriteLine("Computer chose: " + computerChoice);

        // Determine the winner
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
    }
}

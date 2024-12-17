
using System;

class Program
{
    static void Main()
    {
        string[] choices = { "rock", "paper", "scissors" };
        Random random = new Random();

        Console.WriteLine("Let's play Rock-Paper-Scissors! Choose: rock, paper, or scissors.");
        string userChoice = Console.ReadLine().ToLower();

        int computerIndex = random.Next(0, 3);
        string computerChoice = choices[computerIndex];

        Console.WriteLine($"Computer choice: {computerChoice}");

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

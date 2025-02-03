
using System;

class Program
{
    static void Main()
    {
        string[] choices = { "rock", "paper", "scissors" };

        Console.WriteLine("Let's play Rock-Paper-Scissors!");
        Console.Write("Enter your choice (rock, paper, or scissors): ");
        string userChoice = Console.ReadLine().ToLower();

        Random rnd = new Random();
        int computerChoiceIndex = rnd.Next(0, 3);
        string computerChoice = choices[computerChoiceIndex];

        Console.WriteLine("Computer's choice: " + computerChoice);

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
    }
}


using System;

class Program
{
    static void Main()
    {
        string[] choices = { "rock", "paper", "scissors" };

        Random random = new Random();
        int computerChoiceIndex = random.Next(0, 3);
        string computerChoice = choices[computerChoiceIndex];

        Console.WriteLine("Enter your choice (rock, paper, scissors): ");
        string userChoice = Console.ReadLine().ToLower();

        Console.WriteLine($"Computer chose: {computerChoice}");

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

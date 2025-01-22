
using System;

class Program
{
    static void Main()
    {
        string[] choices = { "rock", "paper", "scissors" };

        Random random = new Random();
        int computerChoice = random.Next(choices.Length);
        
        Console.WriteLine("Choose: rock, paper, or scissors");
        string playerChoice = Console.ReadLine().ToLower();

        Console.WriteLine($"Computer chooses: {choices[computerChoice]}");

        if (playerChoice == "rock" && choices[computerChoice] == "scissors" ||
            playerChoice == "paper" && choices[computerChoice] == "rock" ||
            playerChoice == "scissors" && choices[computerChoice] == "paper")
        {
            Console.WriteLine("You win!");
        }
        else if (playerChoice == choices[computerChoice])
        {
            Console.WriteLine("It's a tie!");
        }
        else
        {
            Console.WriteLine("Computer wins!");
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        string[] choices = { "rock", "paper", "scissors" };

        // Computer's choice
        Random random = new Random();
        int computerChoice = random.Next(0, 3);

        // Player's choice
        Console.WriteLine("Choose rock, paper, or scissors:");
        string playerChoice = Console.ReadLine().ToLower();

        Console.WriteLine($"Computer chose: {choices[computerChoice]}");
        Console.WriteLine($"You chose: {playerChoice}");

        // Determine the winner
        if (playerChoice == choices[computerChoice])
        {
            Console.WriteLine("It's a tie!");
        }
        else if ((playerChoice == "rock" && choices[computerChoice] == "scissors") ||
                 (playerChoice == "paper" && choices[computerChoice] == "rock") ||
                 (playerChoice == "scissors" && choices[computerChoice] == "paper"))
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("Computer wins!");
        }
    }
}

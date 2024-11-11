
using System;

class Program
{
    static void Main()
    {
        string[] choices = { "rock", "paper", "scissors" };

        Random rand = new Random();
        int computerChoice = rand.Next(0, 3);

        Console.WriteLine("Choose rock, paper, or scissors:");
        string userChoice = Console.ReadLine().ToLower();

        Console.WriteLine("Computer chooses: " + choices[computerChoice]);

        if (userChoice == choices[computerChoice])
        {
            Console.WriteLine("It's a tie!");
        }
        else if ((userChoice == "rock" && choices[computerChoice] == "scissors") ||
                 (userChoice == "paper" && choices[computerChoice] == "rock") ||
                 (userChoice == "scissors" && choices[computerChoice] == "paper"))
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose!");
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        string[] choices = { "rock", "paper", "scissors" };
        
        Console.WriteLine("Let's play Rock-Paper-Scissors!");
        
        Console.WriteLine("Enter your choice (rock, paper, or scissors):");
        string userChoice = Console.ReadLine().ToLower();
        
        int computerIndex = random.Next(0, 3);
        string computerChoice = choices[computerIndex];
        
        Console.WriteLine($"Computer chose: {computerChoice}");
        
        if(userChoice == computerChoice)
        {
            Console.WriteLine("It's a tie!");
        }
        else if((userChoice == "rock" && computerChoice == "scissors") ||
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

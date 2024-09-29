
using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] choices = { "rock", "paper", "scissors" };
            
            Console.WriteLine("Welcome to Rock-Paper-Scissors!");
            Console.WriteLine("Please choose: rock, paper or scissors:");

            string playerChoice = Console.ReadLine().ToLower();
            Random random = new Random();
            int computerChoiceIndex = random.Next(0, 3);
            string computerChoice = choices[computerChoiceIndex];
            
            Console.WriteLine($"Computer chose: {computerChoice}");
            
            if(playerChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if((playerChoice == "rock" && computerChoice == "scissors") || 
                    (playerChoice == "paper" && computerChoice == "rock") || 
                    (playerChoice == "scissors" && computerChoice == "paper"))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }
        }
    }
}

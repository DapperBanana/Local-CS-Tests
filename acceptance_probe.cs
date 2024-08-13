
using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] choices = { "rock", "paper", "scissors" };
            Random random = new Random();
            int computerChoice = random.Next(0, 3);
            
            Console.WriteLine("Rock, paper, or scissors? (Type your choice): ");
            string userChoice = Console.ReadLine().ToLower();

            Console.WriteLine("Computer choice: " + choices[computerChoice]);

            if ((userChoice == "rock" && choices[computerChoice] == "scissors") ||
                (userChoice == "paper" && choices[computerChoice] == "rock") ||
                (userChoice == "scissors" && choices[computerChoice] == "paper"))
            {
                Console.WriteLine("You win!");
            }
            else if ((userChoice == "rock" && choices[computerChoice] == "paper") ||
                     (userChoice == "paper" && choices[computerChoice] == "scissors") ||
                     (userChoice == "scissors" && choices[computerChoice] == "rock"))
            {
                Console.WriteLine("Computer wins!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }
    }
}

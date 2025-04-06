
using System;

class Program
{
    static void Main()
    {
        string[] options = { "rock", "paper", "scissors" };

        Random random = new Random();
        int computerChoice = random.Next(0, 3);

        Console.WriteLine("Choose: rock, paper, or scissors");
        string userChoice = Console.ReadLine().ToLower();

        Console.WriteLine("Computer chose: " + options[computerChoice]);

        if (userChoice == options[computerChoice])
        {
            Console.WriteLine("It's a tie!");
        }
        else if ((userChoice == "rock" && options[computerChoice] == "scissors") ||
                 (userChoice == "paper" && options[computerChoice] == "rock") ||
                 (userChoice == "scissors" && options[computerChoice] == "paper"))
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("Computer wins!");
        }
    }
}

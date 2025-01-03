
using System;

namespace FantasySportsManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fantasy Football Manager");

            string playerName = "";
            int teamScore = 0;
            string[] teamPlayers = new string[5];

            Console.Write("Enter player name: ");
            playerName = Console.ReadLine();

            Console.WriteLine("Select your team of 5 players:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Player {i + 1}: ");
                teamPlayers[i] = Console.ReadLine();
            }

            Console.WriteLine("Your team has been created!");
            Console.WriteLine($"Player Name: {playerName}");
            Console.WriteLine("Team Players:");
            foreach (string player in teamPlayers)
            {
                Console.WriteLine(player);
            }

            Console.WriteLine("Calculating total team score...");
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int playerScore = random.Next(10, 30);
                Console.WriteLine($"Player {teamPlayers[i]} scored: {playerScore}");
                teamScore += playerScore;
            }

            Console.WriteLine($"Total Team Score: {teamScore}");

            if (teamScore > 100)
            {
                Console.WriteLine("Congratulations! Your team won!");
            }
            else
            {
                Console.WriteLine("Better luck next time! Your team lost!");
            }
        }
    }
}

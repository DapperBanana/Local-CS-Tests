
using System;

class FantasySportsManager
{
    static void Main()
    {
        Console.WriteLine("Welcome to Fantasy Sports Manager!");

        // Initialize variables
        string playerName;
        double playerScore = 0;

        // Get player name from user
        Console.Write("Enter your player name: ");
        playerName = Console.ReadLine();

        // Get player score from user
        Console.Write("Enter your player score: ");
        double.TryParse(Console.ReadLine(), out playerScore);

        // Display player information
        Console.WriteLine("\nPlayer Information");
        Console.WriteLine("Name: " + playerName);
        Console.WriteLine("Score: " + playerScore);

        // Calculate fantasy points based on player score
        int fantasyPoints = (int)playerScore / 10;

        // Display fantasy points
        Console.WriteLine("\nFantasy Points: " + fantasyPoints);

        // Check if player is eligible for playoffs
        if (fantasyPoints > 50)
        {
            Console.WriteLine("\nCongratulations, you are eligible for playoffs!");
        }
        else
        {
            Console.WriteLine("\nSorry, you did not qualify for playoffs.");
        }
    }
}


using System;

class Player
{
    public string Name { get; set; }
    public int Score { get; set; }

    public Player(string name)
    {
        Name = name;
        // Set initial score to zero
        Score = 0;
    }
}

class FantasySportsManager
{
    static void Main()
    {
        Player player1 = new Player("Player 1");
        Player player2 = new Player("Player 2");

        Console.WriteLine("Welcome to Fantasy Sports Manager!");

        Console.WriteLine("Enter the result for Player 1:");
        player1.Score = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the result for Player 2:");
        player2.Score = int.Parse(Console.ReadLine());

        Console.WriteLine("Player 1: {0} - Score: {1}", player1.Name, player1.Score);
        Console.WriteLine("Player 2: {0} - Score: {1}", player2.Name, player2.Score);

        if (player1.Score > player2.Score)
        {
            Console.WriteLine("Player 1 wins!");
        }
        else if (player1.Score < player2.Score)
        {
            Console.WriteLine("Player 2 wins!");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Trading Card Game!");
        Console.WriteLine("---------------------------");

        // Player setup
        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();

        Player player = new Player(playerName);

        // Opponent setup
        Opponent opponent = new Opponent("Opponent");

        // Game loop
        while(player.Health > 0 && opponent.Health > 0)
        {
            Console.WriteLine("\nPlayer's turn:");
            player.PlayTurn(opponent);

            if(opponent.Health <= 0)
            {
                Console.WriteLine("Congratulations, you have defeated the opponent!");
                break;
            }

            Console.WriteLine("\nOpponent's turn:");
            opponent.PlayTurn(player);

            if(player.Health <= 0)
            {
                Console.WriteLine("Game over, the opponent has defeated you.");
                break;
            }
        }

        Console.ReadLine();
    }
}

class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }

    public Player(string name)
    {
        Name = name;
        Health = 100;
        Attack = 10;
    }

    public void PlayTurn(Opponent opponent)
    {
        Console.WriteLine("Player attacks opponent!");
        opponent.Health -= Attack;
        Console.WriteLine($"Opponent's health: {opponent.Health}");
    }
}

class Opponent
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }

    public Opponent(string name)
    {
        Name = name;
        Health = 100;
        Attack = 5;
    }

    public void PlayTurn(Player player)
    {
        Console.WriteLine("Opponent attacks player!");
        player.Health -= Attack;
        Console.WriteLine($"Player's health: {player.Health}");
    }
}


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Trading Card Game!");

        Console.Write("Enter player 1 name: ");
        string player1 = Console.ReadLine();

        Console.Write("Enter player 2 name: ");
        string player2 = Console.ReadLine();

        int player1Health = 20;
        int player2Health = 20;

        Random random = new Random();

        while (player1Health > 0 && player2Health > 0)
        {
            Console.WriteLine($"{player1} - Health: {player1Health}");
            Console.WriteLine($"{player2} - Health: {player2Health}");

            int player1Damage = random.Next(1, 6);
            int player2Damage = random.Next(1, 6);

            Console.WriteLine($"{player1} deals {player1Damage} damage to {player2}");
            player2Health -= player1Damage;

            Console.WriteLine($"{player2} deals {player2Damage} damage to {player1}");
            player1Health -= player2Damage;

            Console.WriteLine();
        }

        if (player1Health <= 0)
        {
            Console.WriteLine($"{player2} wins!");
        }
        else
        {
            Console.WriteLine($"{player1} wins!");
        }
    }
}

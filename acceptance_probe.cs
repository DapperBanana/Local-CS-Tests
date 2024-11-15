
using System;

namespace FantasySportsManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fantasy Sports Manager!");

            Player player = new Player();
            player.Name = "John";
            player.Team = "TeamA";
            player.Points = 100;

            Console.WriteLine($"Player Name: {player.Name}");
            Console.WriteLine($"Player Team: {player.Team}");
            Console.WriteLine($"Player Points: {player.Points}");

            Console.WriteLine("Enter points scored by the player:");
            int pointsScored = Convert.ToInt32(Console.ReadLine());

            player.Points += pointsScored;

            Console.WriteLine($"New total points for the player: {player.Points}");
        }
    }
    
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public int Points { get; set; }
    }
}

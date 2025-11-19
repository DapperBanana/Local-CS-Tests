
using System;
using System.Collections.Generic;

namespace FantasySportsManager
{
    class Player
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Points { get; set; }

        public Player(string name, string position, int points)
        {
            Name = name;
            Position = position;
            Points = points;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            players.Add(new Player("LeBron James", "SF", 25));
            players.Add(new Player("Kevin Durant", "PF", 23));
            players.Add(new Player("Stephen Curry", "PG", 20));
            players.Add(new Player("Anthony Davis", "C", 22));

            Console.WriteLine("Welcome to the Fantasy Sports Manager!");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Players:");
                Console.WriteLine();
                foreach (Player player in players)
                {
                    Console.WriteLine($"{player.Name} - {player.Position} - {player.Points} points");
                }

                Console.WriteLine();
                Console.WriteLine("Enter the name of a player to manage them or type 'quit' to exit:");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                Player selectedPlayer = players.Find(p => p.Name.ToLower() == input.ToLower());

                if (selectedPlayer != null)
                {
                    Console.WriteLine("Options:");
                    Console.WriteLine("1. View player details");
                    Console.WriteLine("2. Trade player");
                    Console.WriteLine("3. Bench player");
                    Console.WriteLine();

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"{selectedPlayer.Name} - {selectedPlayer.Position} - {selectedPlayer.Points} points");
                            break;
                        case 2:
                            Console.WriteLine("Player traded!");
                            players.Remove(selectedPlayer);
                            break;
                        case 3:
                            Console.WriteLine("Player benched!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Player not found. Please try again.");
                }
            }

            Console.WriteLine("Thanks for playing the Fantasy Sports Manager!");
        }
    }
}

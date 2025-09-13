
using System;
using System.Collections.Generic;

namespace FantasySportsManager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>
            {
                new Player("John Doe", "Forward"),
                new Player("Jane Smith", "Midfielder"),
                new Player("Chris Johnson", "Defender"),
                new Player("Emily Davis", "Goalkeeper")
            };

            Console.WriteLine("Welcome to Fantasy Sports Manager!");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. View all players");
                Console.WriteLine("2. Add a player");
                Console.WriteLine("3. Remove a player");
                Console.WriteLine("4. Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("All players:");
                        foreach (Player player in players)
                        {
                            Console.WriteLine(player.Name + " - " + player.Position);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter player name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter player position:");
                        string position = Console.ReadLine();
                        players.Add(new Player(name, position));
                        break;
                    case 3:
                        Console.WriteLine("Enter player name to remove:");
                        string playerName = Console.ReadLine();
                        Player playerToRemove = players.Find(p => p.Name == playerName);
                        players.Remove(playerToRemove);
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }

    class Player
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Player(string name, string position)
        {
            Name = name;
            Position = position;
        }
    }
}

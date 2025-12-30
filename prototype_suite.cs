using System;
using System.Collections.Generic;

namespace FantasySportsManager
{
    class Program
    {
        static List<Player> players = new List<Player>();
        static List<Team> teams = new List<Team>();
        static Team currentTeam;

        static void Main(string[] args)
        {
            InitializePlayers();

            Console.WriteLine("Welcome to the Fantasy Sports Manager!");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. Create a new team");
                Console.WriteLine("2. View existing teams");
                Console.WriteLine("3. Add player to team");
                Console.WriteLine("4. View team roster");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option (1-5): ");

                switch (Console.ReadLine())
                {
                    case "1":
                        CreateTeam();
                        break;
                    case "2":
                        ViewTeams();
                        break;
                    case "3":
                        AddPlayerToTeam();
                        break;
                    case "4":
                        ViewTeamRoster();
                        break;
                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting the Fantasy Sports Manager. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        static void InitializePlayers()
        {
            players.Add(new Player("John Doe", "QB", 85));
            players.Add(new Player("Mike Smith", "RB", 78));
            players.Add(new Player("Alex Johnson", "WR", 80));
            players.Add(new Player("Chris Lee", "TE", 75));
            players.Add(new Player("David Kim", "K", 70));
        }

        static void CreateTeam()
        {
            Console.Write("Enter team name: ");
            string teamName = Console.ReadLine();
            Team team = new Team(teamName);
            teams.Add(team);
            currentTeam = team;
            Console.WriteLine($"Team '{teamName}' created and selected.");
        }

        static void ViewTeams()
        {
            if (teams.Count == 0)
            {
                Console.WriteLine("No teams have been created yet.");
                return;
            }
            Console.WriteLine("Existing Teams:");
            for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {teams[i].Name}");
            }
            Console.Write("Select a team to set as current (enter number): ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= teams.Count)
            {
                currentTeam = teams[index - 1];
                Console.WriteLine($"Team '{currentTeam.Name}' is now selected.");
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }

        static void AddPlayerToTeam()
        {
            if (currentTeam == null)
            {
                Console.WriteLine("Please create or select a team first.");
                return;
            }

            Console.WriteLine("Available players:");
            for (int i = 0; i < players.Count; i++)
            {
                Player p = players[i];
                Console.WriteLine($"{i + 1}. {p.Name} ({p.Position}) - Avg Score: {p.AverageScore}");
            }
            Console.Write("Select a player to add to the team (enter number): ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= players.Count)
            {
                Player selectedPlayer = players[index - 1];
                currentTeam.Roster.Add(selectedPlayer);
                Console.WriteLine($"{selectedPlayer.Name} added to team '{currentTeam.Name}'.");
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }

        static void ViewTeamRoster()
        {
            if (currentTeam == null)
            {
                Console.WriteLine("Please create or select a team first.");
                return;
            }

            Console.WriteLine($"Roster for team '{currentTeam.Name}':");
            if (currentTeam.Roster.Count == 0)
            {
                Console.WriteLine("This team has no players yet.");
            }
            else
            {
                foreach (var player in currentTeam.Roster)
                {
                    Console.WriteLine($"{player.Name} ({player.Position}) - Avg Score: {player.AverageScore}");
                }
            }
        }
    }

    class Player
    {
        public string Name { get; private set; }
        public string Position { get; private set; }
        public int AverageScore { get; private set; }

        public Player(string name, string position, int averageScore)
        {
            Name = name;
            Position = position;
            AverageScore = averageScore;
        }
    }

    class Team
    {
        public string Name { get; private set; }
        public List<Player> Roster { get; private set; }

        public Team(string name)
        {
            Name = name;
            Roster = new List<Player>();
        }
    }
}

using System;
using System.Collections.Generic;

namespace MusicPlaylistManager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> playlist = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a command (add, remove, play, list, exit):");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":
                        Console.WriteLine("Enter song name to add:");
                        string songToAdd = Console.ReadLine();
                        playlist.Add(songToAdd);
                        break;

                    case "remove":
                        Console.WriteLine("Enter song name to remove:");
                        string songToRemove = Console.ReadLine();
                        if (playlist.Contains(songToRemove))
                        {
                            playlist.Remove(songToRemove);
                        }
                        else
                        {
                            Console.WriteLine($"{songToRemove} not found in playlist");
                        }
                        break;

                    case "play":
                        if (playlist.Count > 0)
                        {
                            Console.WriteLine($"Now playing: {playlist[0]}");
                            playlist.RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("Playlist is empty");
                        }
                        break;

                    case "list":
                        Console.WriteLine("Playlist:");
                        foreach (string song in playlist)
                        {
                            Console.WriteLine(song);
                        }
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
        }
    }
}

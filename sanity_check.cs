
using System;
using System.Collections.Generic;

class Program
{
    static List<string> playlist = new List<string>();

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Music Playlist Manager");
            Console.WriteLine("1. Add song to playlist");
            Console.WriteLine("2. Remove song from playlist");
            Console.WriteLine("3. Show playlist");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddSong();
                    break;
                case 2:
                    RemoveSong();
                    break;
                case 3:
                    ShowPlaylist();
                    break;
                case 4:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddSong()
    {
        Console.Write("Enter the name of the song: ");
        string song = Console.ReadLine();

        playlist.Add(song);
        Console.WriteLine("Song added to playlist.");
    }

    static void RemoveSong()
    {
        Console.Write("Enter the name of the song to remove: ");
        string song = Console.ReadLine();

        if (playlist.Remove(song))
        {
            Console.WriteLine("Song removed from playlist.");
        }
        else
        {
            Console.WriteLine("Song not found in playlist.");
        }
    }

    static void ShowPlaylist()
    {
        Console.WriteLine("Current Playlist:");
        foreach (string song in playlist)
        {
            Console.WriteLine("- " + song);
        }
    }
}

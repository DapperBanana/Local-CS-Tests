
using System;
using System.Collections.Generic;

class Program
{
    static List<string> playlist = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Music Playlist Manager");
            Console.WriteLine("1. Add song to playlist");
            Console.WriteLine("2. Remove song from playlist");
            Console.WriteLine("3. Clear playlist");
            Console.WriteLine("4. Display playlist");
            Console.WriteLine("5. Exit");

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
                    ClearPlaylist();
                    break;
                case 4:
                    DisplayPlaylist();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddSong()
    {
        Console.Write("Enter the name of the song: ");
        string song = Console.ReadLine();
        playlist.Add(song);
        Console.WriteLine($"{song} has been added to the playlist.");
    }

    static void RemoveSong()
    {
        Console.Write("Enter the name of the song to remove: ");
        string song = Console.ReadLine();
        if (playlist.Contains(song))
        {
            playlist.Remove(song);
            Console.WriteLine($"{song} has been removed from the playlist.");
        }
        else
        {
            Console.WriteLine("Song not found in the playlist.");
        }
    }

    static void ClearPlaylist()
    {
        playlist.Clear();
        Console.WriteLine("Playlist has been cleared.");
    }

    static void DisplayPlaylist()
    {
        Console.WriteLine("Current playlist:");
        foreach (string song in playlist)
        {
            Console.WriteLine(song);
        }
    }
}


using System;
using System.Collections.Generic;

class Program
{
    static List<string> playlist = new List<string>();

    static void Main()
    {
        Console.WriteLine("Welcome to the Music Playlist Manager!");

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add a song to the playlist");
            Console.WriteLine("2. Display the playlist");
            Console.WriteLine("3. Remove a song from the playlist");
            Console.WriteLine("4. Clear the playlist");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddSong();
                    break;
                case 2:
                    DisplayPlaylist();
                    break;
                case 3:
                    RemoveSong();
                    break;
                case 4:
                    ClearPlaylist();
                    break;
                case 5:
                    isRunning = false;
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
        Console.WriteLine("Song added to the playlist.");
    }

    static void DisplayPlaylist()
    {
        if (playlist.Count == 0)
        {
            Console.WriteLine("Playlist is empty.");
        }
        else
        {
            Console.WriteLine("Playlist:");
            foreach (string song in playlist)
            {
                Console.WriteLine("- " + song);
            }
        }
    }

    static void RemoveSong()
    {
        Console.Write("Enter the name of the song to remove: ");
        string song = Console.ReadLine();

        if (playlist.Contains(song))
        {
            playlist.Remove(song);
            Console.WriteLine("Song removed from the playlist.");
        }
        else
        {
            Console.WriteLine("Song not found in the playlist.");
        }
    }

    static void ClearPlaylist()
    {
        playlist.Clear();
        Console.WriteLine("Playlist cleared.");
    }
}

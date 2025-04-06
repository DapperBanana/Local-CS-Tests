
using System;
using System.Collections.Generic;

class PlaylistManager
{
    static List<string> playlist = new List<string>();

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Welcome to the Music Playlist Manager!");
            Console.WriteLine("1. Add a song to the playlist");
            Console.WriteLine("2. View the playlist");
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
                    ViewPlaylist();
                    break;
                case 3:
                    RemoveSong();
                    break;
                case 4:
                    ClearPlaylist();
                    break;
                case 5:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddSong()
    {
        Console.Write("Enter the name of the song to add: ");
        string song = Console.ReadLine();
        playlist.Add(song);
        Console.WriteLine(song + " added to the playlist.");
    }

    static void ViewPlaylist()
    {
        if(playlist.Count == 0)
        {
            Console.WriteLine("The playlist is empty.");
        }
        else
        {
            Console.WriteLine("Playlist:");
            foreach (var song in playlist)
            {
                Console.WriteLine(song);
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
            Console.WriteLine(song + " removed from the playlist.");
        }
        else
        {
            Console.WriteLine(song + " not found in the playlist.");
        }
    }

    static void ClearPlaylist()
    {
        playlist.Clear();
        Console.WriteLine("Playlist cleared.");
    }
}

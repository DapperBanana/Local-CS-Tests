
using System;
using System.Collections.Generic;

class Program
{
    static List<string> playlist = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Add a song to the playlist");
            Console.WriteLine("2. Play the next song");
            Console.WriteLine("3. Show current playlist");
            Console.WriteLine("4. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddSong();
                    break;
                case 2:
                    PlayNextSong();
                    break;
                case 3:
                    ShowPlaylist();
                    break;
                case 4:
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
        Console.WriteLine("Enter the name of the song:");
        string song = Console.ReadLine();
        playlist.Add(song);
        Console.WriteLine("Song added to the playlist.");
    }

    static void PlayNextSong()
    {
        if (playlist.Count == 0)
        {
            Console.WriteLine("No songs in the playlist.");
        }
        else
        {
            Console.WriteLine("Playing: " + playlist[0]);
            playlist.RemoveAt(0);
        }
    }

    static void ShowPlaylist()
    {
        if (playlist.Count == 0)
        {
            Console.WriteLine("No songs in the playlist.");
        }
        else
        {
            Console.WriteLine("Current playlist:");
            foreach (string song in playlist)
            {
                Console.WriteLine(song);
            }
        }
    }
}

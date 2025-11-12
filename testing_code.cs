
using System;
using System.Collections.Generic;

class Program
{
    static List<string> playlist = new List<string>();

    static void Main(string[] args)
    {
        bool isPlaying = false;

        while (true)
        {
            Console.WriteLine("Music Playlist Manager");
            Console.WriteLine("1. Add a song to the playlist");
            Console.WriteLine("2. Show current playlist");
            Console.WriteLine("3. Play playlist");
            Console.WriteLine("4. Stop playlist");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the name of the song: ");
                    string songName = Console.ReadLine();
                    playlist.Add(songName);
                    Console.WriteLine("Song added to playlist.");
                    break;
                case 2:
                    ShowPlaylist();
                    break;
                case 3:
                    isPlaying = true;
                    PlayPlaylist();
                    break;
                case 4:
                    isPlaying = false;
                    Console.WriteLine("Playlist stopped.");
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

    static void ShowPlaylist()
    {
        Console.WriteLine("Current Playlist:");
        foreach (string song in playlist)
        {
            Console.WriteLine("- " + song);
        }
    }

    static void PlayPlaylist()
    {
        foreach (string song in playlist)
        {
            if (isPlaying)
            {
                Console.WriteLine("Playing: " + song);
                Console.WriteLine("Press any key to play the next song...");
                Console.ReadLine();
            }
            else
            {
                break;
            }
        }
    }
}

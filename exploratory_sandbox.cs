
using System;
using System.Collections.Generic;

class Program
{
    static List<string> playlist = new List<string>();

    static void Main(string[] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Welcome to the Music Playlist Manager!");
            Console.WriteLine("1. Add song to playlist");
            Console.WriteLine("2. View playlist");
            Console.WriteLine("3. Remove song from playlist");
            Console.WriteLine("4. Clear playlist");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddSongToPlaylist();
                    break;
                case 2:
                    ViewPlaylist();
                    break;
                case 3:
                    RemoveSongFromPlaylist();
                    break;
                case 4:
                    ClearPlaylist();
                    break;
                case 5:
                    isRunning = false;
                    Console.WriteLine("Thank you for using the Music Playlist Manager!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddSongToPlaylist()
    {
        Console.WriteLine("Enter the name of the song to add:");
        string song = Console.ReadLine();
        playlist.Add(song);
        Console.WriteLine("Song added to playlist successfully.");
    }

    static void ViewPlaylist()
    {
        if (playlist.Count == 0)
        {
            Console.WriteLine("Playlist is empty.");
        }
        else
        {
            Console.WriteLine("Playlist:");
            for (int i = 0; i < playlist.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {playlist[i]}");
            }
        }
    }

    static void RemoveSongFromPlaylist()
    {
        ViewPlaylist();
        Console.WriteLine("Enter the number of the song to remove:");
        int index = int.Parse(Console.ReadLine());
        if (index < 1 || index > playlist.Count)
        {
            Console.WriteLine("Invalid song number.");
        }
        else
        {
            playlist.RemoveAt(index - 1);
            Console.WriteLine("Song removed from playlist.");
        }
    }

    static void ClearPlaylist()
    {
        playlist.Clear();
        Console.WriteLine("Playlist cleared.");
    }
}

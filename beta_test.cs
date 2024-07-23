
using System;
using System.Collections.Generic;

class Program
{
    static List<string> playlist = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Add song to playlist");
            Console.WriteLine("2. View playlist");
            Console.WriteLine("3. Remove song from playlist");
            Console.WriteLine("4. Clear playlist");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice:");

            int choice = int.Parse(Console.ReadLine());

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
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    static void AddSong()
    {
        Console.WriteLine("Enter the name of the song to add:");
        string song = Console.ReadLine();
        playlist.Add(song);
        Console.WriteLine("Song added to playlist");
    }

    static void ViewPlaylist()
    {
        Console.WriteLine("Playlist:");
        for (int i = 0; i < playlist.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + playlist[i]);
        }
    }

    static void RemoveSong()
    {
        Console.WriteLine("Enter the index of the song to remove:");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < playlist.Count)
        {
            playlist.RemoveAt(index);
            Console.WriteLine("Song removed from playlist");
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }

    static void ClearPlaylist()
    {
        playlist.Clear();
        Console.WriteLine("Playlist cleared");
    }
}

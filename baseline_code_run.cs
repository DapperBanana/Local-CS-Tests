
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> playlist = new List<string>();

        while (true)
        {
            Console.WriteLine("Music Playlist Manager");
            Console.WriteLine("1. Add song to playlist");
            Console.WriteLine("2. View playlist");
            Console.WriteLine("3. Remove song from playlist");
            Console.WriteLine("4. Clear playlist");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter song name: ");
                    string songName = Console.ReadLine();
                    playlist.Add(songName);
                    Console.WriteLine("Song added to playlist!");
                    break;
                case "2":
                    Console.WriteLine("Playlist:");
                    foreach (string song in playlist)
                    {
                        Console.WriteLine(song);
                    }
                    break;
                case "3":
                    Console.Write("Enter song name to remove: ");
                    string songToRemove = Console.ReadLine();
                    if (playlist.Contains(songToRemove))
                    {
                        playlist.Remove(songToRemove);
                        Console.WriteLine("Song removed from playlist!");
                    }
                    else
                    {
                        Console.WriteLine("Song not found in playlist.");
                    }
                    break;
                case "4":
                    playlist.Clear();
                    Console.WriteLine("Playlist cleared!");
                    break;
                case "5":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

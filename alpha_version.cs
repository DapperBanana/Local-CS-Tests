
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to store the playlist
        List<string> playlist = new List<string>();

        while (true)
        {
            Console.WriteLine("Music Playlist Manager");
            Console.WriteLine("1. Add song to playlist");
            Console.WriteLine("2. Remove song from playlist");
            Console.WriteLine("3. Display playlist");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the name of the song: ");
                    string song = Console.ReadLine();
                    playlist.Add(song);
                    Console.WriteLine("Song added to playlist!");
                    break;
                case 2:
                    Console.Write("Enter the name of the song to remove: ");
                    string songToRemove = Console.ReadLine();
                    if (playlist.Contains(songToRemove))
                    {
                        playlist.Remove(songToRemove);
                        Console.WriteLine("Song removed from playlist!");
                    }
                    else
                    {
                        Console.WriteLine("Song not found in playlist!");
                    }
                    break;
                case 3:
                    Console.WriteLine("Current Playlist:");
                    foreach (string s in playlist)
                    {
                        Console.WriteLine("- " + s);
                    }
                    break;
                case 4:
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}

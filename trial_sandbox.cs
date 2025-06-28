
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
            Console.WriteLine("1. Add a song");
            Console.WriteLine("2. Remove a song");
            Console.WriteLine("3. View playlist");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the name of the song: ");
                    string song = Console.ReadLine();
                    playlist.Add(song);
                    Console.WriteLine("Song added to the playlist.");
                    break;
                case 2:
                    Console.Write("Enter the index of the song to remove: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    if (index >= 0 && index < playlist.Count)
                    {
                        playlist.RemoveAt(index);
                        Console.WriteLine("Song removed from the playlist.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Playlist:");
                    for (int i = 0; i < playlist.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {playlist[i]}");
                    }
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
}

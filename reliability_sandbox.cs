
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> playlist = new List<string>();

        while (true)
        {
            Console.WriteLine("\nMusic Playlist Manager");
            Console.WriteLine("1. Add song to playlist");
            Console.WriteLine("2. Remove song from playlist");
            Console.WriteLine("3. View playlist");
            Console.WriteLine("4. Exit");

            Console.Write("Choose an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter song name: ");
                    string song = Console.ReadLine();
                    playlist.Add(song);
                    Console.WriteLine("Song added to playlist");
                    break;

                case 2:
                    Console.Write("Enter the index of the song to remove: ");
                    int index = int.Parse(Console.ReadLine());
                    if (index >= 0 && index < playlist.Count)
                    {
                        playlist.RemoveAt(index);
                        Console.WriteLine("Song removed from playlist");
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    break;

                case 3:
                    Console.WriteLine("\nPlaylist:");
                    for (int i = 0; i < playlist.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {playlist[i]}");
                    }
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}

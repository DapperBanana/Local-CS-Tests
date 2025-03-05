
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> playlist = new List<string>();

        while (true)
        {
            Console.WriteLine("1. Add song to playlist");
            Console.WriteLine("2. Display playlist");
            Console.WriteLine("3. Clear playlist");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the name of the song: ");
                    string song = Console.ReadLine();
                    playlist.Add(song);
                    Console.WriteLine("Song added to playlist.");
                    break;

                case 2:
                    Console.WriteLine("Playlist:");
                    foreach (string item in playlist)
                    {
                        Console.WriteLine("- " + item);
                    }
                    break;

                case 3:
                    playlist.Clear();
                    Console.WriteLine("Playlist cleared.");
                    break;

                case 4:
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

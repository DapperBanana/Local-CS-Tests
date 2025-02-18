
using System;
using System.Collections.Generic;

namespace MusicPlaylistManager
{
    class Program
    {
        static List<string> playlist = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Music Playlist Manager!");

            bool playing = true;

            while (playing)
            {
                DisplayMenu();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddSong();
                        break;
                    case "2":
                        DisplayPlaylist();
                        break;
                    case "3":
                        RemoveSong();
                        break;
                    case "4":
                        playing = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            Console.WriteLine("Goodbye! Have a great day.");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n1. Add a song to the playlist");
            Console.WriteLine("2. Display playlist");
            Console.WriteLine("3. Remove a song from the playlist");
            Console.WriteLine("4. Exit");
            Console.Write("\nEnter your choice: ");
        }

        static void AddSong()
        {
            Console.Write("Enter the name of the song: ");
            string song = Console.ReadLine();
            playlist.Add(song);
            Console.WriteLine("Song added to the playlist.");
        }

        static void DisplayPlaylist()
        {
            Console.WriteLine("\nPlaylist:");
            foreach (string song in playlist)
            {
                Console.WriteLine("- " + song);
            }
        }

        static void RemoveSong()
        {
            DisplayPlaylist();
            Console.Write("Enter the index of the song to remove: ");
            int index = int.Parse(Console.ReadLine());
            if (index >= 0 && index < playlist.Count)
            {
                playlist.RemoveAt(index);
                Console.WriteLine("Song removed from the playlist.");
            }
            else
            {
                Console.WriteLine("Invalid index. Please try again.");
            }
        }
    }
}

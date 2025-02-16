
using System;
using System.Collections.Generic;

namespace PlaylistManager
{
    class Program
    {
        static List<string> playlist = new List<string>();

        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Music Playlist Manager");
                Console.WriteLine("1. Add song to playlist");
                Console.WriteLine("2. Remove song from playlist");
                Console.WriteLine("3. View playlist");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddSongToPlaylist();
                        break;
                    case 2:
                        RemoveSongFromPlaylist();
                        break;
                    case 3:
                        ViewPlaylist();
                        break;
                    case 4:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddSongToPlaylist()
        {
            Console.Write("Enter song name: ");
            string song = Console.ReadLine();
            playlist.Add(song);
            Console.WriteLine("Song added to playlist.");
        }

        static void RemoveSongFromPlaylist()
        {
            Console.Write("Enter song name to remove: ");
            string song = Console.ReadLine();
            if (playlist.Contains(song))
            {
                playlist.Remove(song);
                Console.WriteLine("Song removed from playlist.");
            }
            else
            {
                Console.WriteLine("Song not found in playlist.");
            }
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
                foreach (string song in playlist)
                {
                    Console.WriteLine(song);
                }
            }
        }
    }
}

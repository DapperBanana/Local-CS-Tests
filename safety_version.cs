
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> playlist = new List<string>();
        
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add song to playlist");
            Console.WriteLine("2. Play next song");
            Console.WriteLine("3. Show playlist");
            Console.WriteLine("4. Exit");
            
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Console.Write("Enter the name of the song to add: ");
                    string song = Console.ReadLine();
                    playlist.Add(song);
                    Console.WriteLine("Song added to playlist.");
                    break;
                
                case 2:
                    if (playlist.Count == 0)
                    {
                        Console.WriteLine("Playlist is empty.");
                    }
                    else
                    {
                        string currentSong = playlist[0];
                        Console.WriteLine("Now playing: " + currentSong);
                        playlist.RemoveAt(0);
                    }
                    break;
                
                case 3:
                    Console.WriteLine("Current playlist:");
                    foreach (string s in playlist)
                    {
                        Console.WriteLine("- " + s);
                    }
                    break;
                
                case 4:
                    Console.WriteLine("Exiting program.");
                    Environment.Exit(0);
                    break;
                
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

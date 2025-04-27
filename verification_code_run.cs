
using System;
using System.Collections.Generic;

class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }

    public Song(string title, string artist)
    {
        Title = title;
        Artist = artist;
    }
}

class PlaylistManager
{
    private List<Song> playlist = new List<Song>();

    public void AddSong(string title, string artist)
    {
        Song newSong = new Song(title, artist);
        playlist.Add(newSong);
        Console.WriteLine($"Added '{title}' by {artist} to the playlist.");
    }

    public void DisplayPlaylist()
    {
        Console.WriteLine("Current Playlist:");
        foreach (Song song in playlist)
        {
            Console.WriteLine($"- {song.Title} by {song.Artist}");
        }
    }
}

class Program
{
    static void Main()
    {
        PlaylistManager playlistManager = new PlaylistManager();

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add song to playlist");
            Console.WriteLine("2. Display playlist");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter song title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter artist name: ");
                    string artist = Console.ReadLine();
                    playlistManager.AddSong(title, artist);
                    break;
                case "2":
                    playlistManager.DisplayPlaylist();
                    break;
                case "3":
                    Console.WriteLine("Exiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

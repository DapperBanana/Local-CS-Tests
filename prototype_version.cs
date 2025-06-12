
using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, List<string>> movieGenres = new Dictionary<string, List<string>>()
    {
        { "Action", new List<string> { "Die Hard", "Mad Max", "The Dark Knight" } },
        { "Comedy", new List<string> { "The Hangover", "Superbad", "Anchorman" } },
        { "Drama", new List<string> { "The Shawshank Redemption", "Forrest Gump", "The Godfather" } }
    };

    static void Main()
    {
        Console.WriteLine("Welcome to the Movie Recommendation System!");
        Console.WriteLine();

        Console.WriteLine("Choose a genre to get movie recommendations:");
        foreach (var genre in movieGenres.Keys)
        {
            Console.WriteLine(genre);
        }

        string selectedGenre = Console.ReadLine();

        if (movieGenres.ContainsKey(selectedGenre))
        {
            Console.WriteLine("Here are some movie recommendations for the genre " + selectedGenre + ":");
            foreach (var movie in movieGenres[selectedGenre])
            {
                Console.WriteLine(movie);
            }
        }
        else
        {
            Console.WriteLine("Invalid genre selection. Please try again.");
        }
    }
}

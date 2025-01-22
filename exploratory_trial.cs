
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> movieGenres = new Dictionary<string, List<string>>
        {
            { "Action", new List<string> { "The Dark Knight", "Inception", "Avengers", "Die Hard" } },
            { "Comedy", new List<string> { "Superbad", "The Hangover", "Anchorman", "Bridesmaids" } },
            { "Drama", new List<string> { "The Shawshank Redemption", "Forrest Gump", "The Godfather", "Titanic" } }
        };

        Console.WriteLine("Welcome to the Movie Recommendation System!");
        Console.WriteLine("What genre are you interested in? (Action, Comedy, Drama)");

        string genre = Console.ReadLine();

        if (movieGenres.ContainsKey(genre))
        {
            List<string> movies = movieGenres[genre];

            Console.WriteLine("Here are some recommended movies in the " + genre + " genre:");
            foreach (string movie in movies)
            {
                Console.WriteLine("- " + movie);
            }
        }
        else
        {
            Console.WriteLine("Sorry, we don't have recommendations for that genre.");
        }
    }
}

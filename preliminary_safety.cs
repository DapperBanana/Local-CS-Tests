
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> movieGenres = new Dictionary<string, List<string>>()
        {
            {"Action", new List<string>{"Die Hard", "The Avengers", "John Wick"}},
            {"Comedy", new List<string>{"Superbad", "Bridesmaids", "Dumb and Dumber"}},
            {"Drama", new List<string>{"The Shawshank Redemption", "The Godfather", "Forrest Gump"}}
        };

        Console.WriteLine("Welcome to the Movie Recommendation System!");

        Console.WriteLine("Here are the available movie genres:");
        foreach (string genre in movieGenres.Keys)
        {
            Console.WriteLine(genre);
        }

        Console.Write("Enter a genre to get a movie recommendation: ");
        string userGenre = Console.ReadLine();

        if (movieGenres.ContainsKey(userGenre))
        {
            Random rand = new Random();
            List<string> moviesInGenre = movieGenres[userGenre];
            string recommendedMovie = moviesInGenre[rand.Next(moviesInGenre.Count)];

            Console.WriteLine($"We recommend watching: {recommendedMovie}");
        }
        else
        {
            Console.WriteLine("Invalid genre selected. Please try again.");
        }
    }
}

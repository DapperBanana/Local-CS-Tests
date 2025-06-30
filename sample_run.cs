
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> movieGenres = new Dictionary<string, List<string>>()
        {
            { "Action", new List<string> { "Die Hard", "The Dark Knight", "Mad Max: Fury Road" } },
            { "Comedy", new List<string> { "Superbad", "Bridesmaids", "The Hangover" } },
            { "Drama", new List<string> { "The Shawshank Redemption", "Titanic", "Forrest Gump" } },
            { "Horror", new List<string> { "The Exorcist", "Get Out", "A Nightmare on Elm Street" } }
        };

        Console.WriteLine("Welcome to the Movie Recommendation System!");
        Console.Write("Choose a genre (Action, Comedy, Drama, Horror): ");
        string inputGenre = Console.ReadLine();

        if (movieGenres.ContainsKey(inputGenre))
        {
            List<string> recommendations = movieGenres[inputGenre];
            Console.WriteLine("Here are some movie recommendations in the " + inputGenre + " genre:");
            foreach (string recommendation in recommendations)
            {
                Console.WriteLine("- " + recommendation);
            }
        }
        else
        {
            Console.WriteLine("Invalid genre entered. Please try again.");
        }
    }
}

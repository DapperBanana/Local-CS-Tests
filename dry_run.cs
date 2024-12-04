
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> movieGenres = new Dictionary<string, List<string>>
        {
            { "Action", new List<string> { "Die Hard", "Terminator", "Mad Max" }},
            { "Comedy", new List<string> { "Superbad", "Anchorman", "Bridesmaids" }},
            { "Drama", new List<string> { "The Shawshank Redemption", "The Godfather", "Pulp Fiction" }},
            { "Horror", new List<string> { "The Exorcist", "Halloween", "Psycho" }}
        };

        Console.WriteLine("Welcome to the Movie Recommendation System!");
        Console.WriteLine("Please select a genre: Action, Comedy, Drama, Horror");

        string selectedGenre = Console.ReadLine();

        if (movieGenres.ContainsKey(selectedGenre))
        {
            List<string> recommendedMovies = movieGenres[selectedGenre];
            Console.WriteLine("Here are some recommended movies in the " + selectedGenre + " genre:");
            
            foreach (string movie in recommendedMovies)
            {
                Console.WriteLine(movie);
            }
        }
        else
        {
            Console.WriteLine("Invalid genre selected!");
        }
    }
}

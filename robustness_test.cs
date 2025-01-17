
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> genreToMovies = new Dictionary<string, List<string>>();
        
        genreToMovies.Add("Action", new List<string>() { "The Dark Knight", "Avengers", "Mad Max: Fury Road" });
        genreToMovies.Add("Comedy", new List<string>() { "Superbad", "The Hangover", "Bridesmaids" });
        genreToMovies.Add("Drama", new List<string>() { "The Shawshank Redemption", "Forrest Gump", "12 Years a Slave" });
        
        Console.WriteLine("Welcome to the movie recommendation system!");
        Console.WriteLine("Enter a genre (Action, Comedy, Drama) to get a movie recommendation: ");
        
        string genreInput = Console.ReadLine();
        if (genreToMovies.ContainsKey(genreInput))
        {
            List<string> movies = genreToMovies[genreInput];
            Random rand = new Random();
            string randomMovie = movies[rand.Next(movies.Count)];
            Console.WriteLine($"We recommend watching: {randomMovie}");
        }
        else
        {
            Console.WriteLine("Sorry, we do not have recommendations for that genre.");
        }
    }
}

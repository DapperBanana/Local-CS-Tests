
using System;
using System.Collections.Generic;

class MovieRecommendationSystem
{
    static void Main()
    {
        Dictionary<string, string> movies = new Dictionary<string, string>();
        movies.Add("The Shawshank Redemption", "Drama");
        movies.Add("The Godfather", "Crime");
        movies.Add("The Dark Knight", "Action");
        movies.Add("Forrest Gump", "Drama");
        movies.Add("Pulp Fiction", "Crime");

        Console.WriteLine("Welcome to the Movie Recommendation System!");
        Console.WriteLine("Please enter your favorite genre (Drama, Crime, Action): ");
        string inputGenre = Console.ReadLine();

        List<string> recommendedMovies = new List<string>();
        foreach (var movie in movies)
        {
            if (movie.Value == inputGenre)
            {
                recommendedMovies.Add(movie.Key);
            }
        }

        if (recommendedMovies.Count > 0)
        {
            Console.WriteLine("Recommended movies in the " + inputGenre + " genre:");
            foreach (var recommendedMovie in recommendedMovies)
            {
                Console.WriteLine(recommendedMovie);
            }
        }
        else
        {
            Console.WriteLine("Sorry, no recommended movies in the " + inputGenre + " genre.");
        }
    }
}

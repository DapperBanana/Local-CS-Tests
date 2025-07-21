
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> userPreferences = new Dictionary<string, List<string>>
        {
            {"User1", new List<string> { "action", "comedy", "drama"} },
            {"User2", new List<string> { "comedy", "horror", "sci-fi"} },
            {"User3", new List<string> { "drama", "romance", "thriller"} }
        };

        Dictionary<string, List<string>> movieGenres = new Dictionary<string, List<string>>
        {
            {"Movie1", new List<string> { "action", "thriller"} },
            {"Movie2", new List<string> { "comedy", "romance"} },
            {"Movie3", new List<string> { "drama", "action"} }
        };

        string user = "User1";

        List<string> recommendedMovies = GetRecommendedMovies(user, userPreferences, movieGenres);

        Console.WriteLine($"Recommended movies for {user}:");
        foreach (string movie in recommendedMovies)
        {
            Console.WriteLine(movie);
        }
    }

    static List<string> GetRecommendedMovies(string user, Dictionary<string, List<string>> userPreferences, Dictionary<string, List<string>> movieGenres)
    {
        List<string> recommendedMovies = new List<string>();

        foreach (var movieGenre in movieGenres)
        {
            if (userPreferences[user].Intersect(movieGenre.Value).Any())
            {
                recommendedMovies.Add(movieGenre.Key);
            }
        }

        return recommendedMovies;
    }
}

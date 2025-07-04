
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Sample data for movies and user preferences
        Dictionary<string, Dictionary<string, int>> userPreferences = new Dictionary<string, Dictionary<string, int>>();
        userPreferences["Alice"] = new Dictionary<string, int> { { "Action", 5 }, { "Drama", 4 }, { "Comedy", 2 } };
        userPreferences["Bob"] = new Dictionary<string, int> { { "Action", 3 }, { "Drama", 2 }, { "Comedy", 4 } };

        Dictionary<string, Dictionary<string, int>> movieGenres = new Dictionary<string, Dictionary<string, int>>();
        movieGenres["Movie1"] = new Dictionary<string, int> { { "Action", 1 }, { "Drama", 0 }, { "Comedy", 1 } };
        movieGenres["Movie2"] = new Dictionary<string, int> { { "Action", 0 }, { "Drama", 1 }, { "Comedy", 0 } };

        // Get recommendations for Alice
        string user = "Alice";
        Dictionary<string, double> recommendations = GetRecommendations(user, userPreferences, movieGenres);

        Console.WriteLine($"Recommendations for {user}:");
        foreach (var movie in recommendations)
        {
            Console.WriteLine($"{movie.Key}: {movie.Value}");
        }
    }

    static Dictionary<string, double> GetRecommendations(string user, Dictionary<string, Dictionary<string, int>> userPreferences, Dictionary<string, Dictionary<string, int>> movieGenres)
    {
        Dictionary<string, double> recommendations = new Dictionary<string, double>();
        Dictionary<string, int> userRatings = userPreferences[user];

        foreach (var movie in movieGenres)
        {
            double score = 0;
            foreach (var genre in movie.Value)
            {
                if (userRatings.ContainsKey(genre.Key))
                {
                    score += userRatings[genre.Key] * genre.Value;
                }
            }
            recommendations[movie.Key] = score;
        }

        return recommendations;
    }
}

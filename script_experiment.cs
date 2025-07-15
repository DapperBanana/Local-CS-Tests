
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> userPreferences = new Dictionary<string, Dictionary<string, int>>
        {
            { "Alice", new Dictionary<string, int> { { "Action", 5 }, { "Comedy", 3 }, { "Drama", 2 } } },
            { "Bob", new Dictionary<string, int> { { "Action", 2 }, { "Comedy", 4 }, { "Drama", 5 } } },
            { "Charlie", new Dictionary<string, int> { { "Action", 4 }, { "Comedy", 1 }, { "Drama", 3 } } }
        };

        Dictionary<string, Dictionary<string, int>> movieFeatures = new Dictionary<string, Dictionary<string, int>>
        {
            { "Movie1", new Dictionary<string, int> { { "Action", 1 }, { "Comedy", 5 }, { "Drama", 3 } } },
            { "Movie2", new Dictionary<string, int> { { "Action", 4 }, { "Comedy", 2 }, { "Drama", 1 } } },
            { "Movie3", new Dictionary<string, int> { { "Action", 3 }, { "Comedy", 4 }, { "Drama", 2 } } }
        };

        Console.WriteLine("User Preferences:");
        foreach (var user in userPreferences)
        {
            Console.WriteLine(user.Key);
            foreach (var genre in user.Value)
            {
                Console.WriteLine($"{genre.Key}: {genre.Value}");
            }
        }

        Console.WriteLine("\nMovie Features:");
        foreach (var movie in movieFeatures)
        {
            Console.WriteLine(movie.Key);
            foreach (var genre in movie.Value)
            {
                Console.WriteLine($"{genre.Key}: {genre.Value}");
            }
        }

        Console.WriteLine("\nRecommendations:");
        foreach (var user in userPreferences)
        {
            Console.WriteLine($"Recommendations for {user.Key}:");
            List<string> recommendedMovies = new List<string>();

            foreach (var movie in movieFeatures)
            {
                int score = 0;
                foreach (var genre in user.Value)
                {
                    score += genre.Value * movie.Value.GetValueOrDefault(genre.Key, 0);
                }

                if (score >= 10)
                {
                    recommendedMovies.Add(movie.Key);
                }
            }

            Console.WriteLine(string.Join(", ", recommendedMovies));
        }
    }
}

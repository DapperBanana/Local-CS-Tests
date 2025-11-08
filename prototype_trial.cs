
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a dictionary to store user preferences
        Dictionary<string, Dictionary<string, int>> preferences = new Dictionary<string, Dictionary<string, int>>();

        // Add some example preferences
        preferences["Alice"] = new Dictionary<string, int>
        {
            {"action", 5},
            {"comedy", 3},
            {"drama", 2}
        };

        preferences["Bob"] = new Dictionary<string, int>
        {
            {"action", 2},
            {"comedy", 4},
            {"drama", 5}
        };

        preferences["Charlie"] = new Dictionary<string, int>
        {
            {"action", 4},
            {"comedy", 1},
            {"drama", 4}
        };

        // Calculate similarity between users using cosine similarity
        string user1 = "Alice";
        string user2 = "Bob";

        double dotProduct = 0;
        double magnitude1 = 0;
        double magnitude2 = 0;

        foreach (var genre in preferences[user1].Keys)
        {
            dotProduct += preferences[user1][genre] * preferences[user2][genre];
            magnitude1 += Math.Pow(preferences[user1][genre], 2);
            magnitude2 += Math.Pow(preferences[user2][genre], 2);
        }

        double similarity = dotProduct / (Math.Sqrt(magnitude1) * Math.Sqrt(magnitude2));

        Console.WriteLine("Similarity between {0} and {1}: {2}", user1, user2, similarity);

        // Recommend movies to user based on similarity
        List<string> recommendedMovies = new List<string>();
        foreach (var genre in preferences[user2].Keys)
        {
            if (preferences[user2][genre] >= 4 && preferences[user1][genre] < 4)
            {
                recommendedMovies.Add(genre);
            }
        }

        Console.WriteLine("Recommended movies for {0}:", user1);
        foreach (var movie in recommendedMovies)
        {
            Console.WriteLine(movie);
        }
    }
}

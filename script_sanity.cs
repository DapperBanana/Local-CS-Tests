
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, double>> userPreferences = new Dictionary<string, Dictionary<string, double>>();
        // Add user preferences
        userPreferences["User1"] = new Dictionary<string, double> { { "Action", 4.5 }, { "Comedy", 2.5 }, { "Drama", 3.0 } };
        userPreferences["User2"] = new Dictionary<string, double> { { "Action", 3.0 }, { "Comedy", 4.0 }, { "Drama", 2.5 } };

        Dictionary<string, double> newMovie = new Dictionary<string, double> { { "Action", 3.5 }, { "Comedy", 4.0 }, { "Drama", 2.0 } };

        // Calculate similarity between user preferences and new movie
        Dictionary<string, double> similarities = new Dictionary<string, double>();
        foreach (var user in userPreferences)
        {
            double similarity = 0.0;
            foreach (var genre in user.Value.Keys)
            {
                similarity += Math.Pow(user.Value[genre] - newMovie[genre], 2);
            }
            similarities[user.Key] = 1 / (1 + Math.Sqrt(similarity));
        }

        // Recommend movie to user with highest similarity
        string recommendedUser = "";
        double maxSimilarity = 0.0;
        foreach (var user in similarities)
        {
            if (user.Value > maxSimilarity)
            {
                maxSimilarity = user.Value;
                recommendedUser = user.Key;
            }
        }

        Console.WriteLine("Recommended movie to " + recommendedUser);
    }
}

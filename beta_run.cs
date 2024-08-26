
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, double>> preferences = new Dictionary<string, Dictionary<string, double>>();

        preferences["Alice"] = new Dictionary<string, double>();
        preferences["Alice"]["action"] = 4.0;
        preferences["Alice"]["comedy"] = 5.0;
        preferences["Alice"]["drama"] = 2.0;

        preferences["Bob"] = new Dictionary<string, double>();
        preferences["Bob"]["action"] = 5.0;
        preferences["Bob"]["comedy"] = 3.0;
        preferences["Bob"]["drama"] = 4.0;

        preferences["Charlie"] = new Dictionary<string, double>();
        preferences["Charlie"]["action"] = 2.0;
        preferences["Charlie"]["comedy"] = 4.0;
        preferences["Charlie"]["drama"] = 5.0;

        string user = "Alice";
        Console.WriteLine($"Recommendations for {user}:");
        foreach (var movie in GetRecommendations(preferences, user))
        {
            Console.WriteLine(movie);
        }
    }

    static List<string> GetRecommendations(Dictionary<string, Dictionary<string, double>> preferences, string user)
    {
        List<string> recommendedMovies = new List<string>();
        Dictionary<string, double> userPreferences = preferences[user];

        foreach (var otherUser in preferences)
        {
            if (otherUser.Key == user)
                continue;

            double similarity = GetSimilarity(userPreferences, otherUser.Value);
            if (similarity > 0.5)
            {
                foreach (var movie in otherUser.Value)
                {
                    if (!userPreferences.ContainsKey(movie.Key))
                    {
                        recommendedMovies.Add(movie.Key);
                    }
                }
            }
        }

        return recommendedMovies;
    }

    static double GetSimilarity(Dictionary<string, double> user1Preferences, Dictionary<string, double> user2Preferences)
    {
        double sum_of_squares = 0;
        foreach (var pref in user1Preferences)
        {
            if (user2Preferences.ContainsKey(pref.Key))
            {
                sum_of_squares += Math.Pow(pref.Value - user2Preferences[pref.Key], 2);
            }
        }

        return 1 / (1 + Math.Sqrt(sum_of_squares));
    }
}

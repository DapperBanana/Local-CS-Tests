
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, double>> userPreferences = new Dictionary<string, Dictionary<string, double>>()
        {
            { "Alice", new Dictionary<string, double>(){
                { "Action", 5.0},
                { "Comedy", 4.0},
                { "Drama", 3.0}
            }},
            { "Bob", new Dictionary<string, double>(){
                { "Action", 3.0},
                { "Comedy", 4.0},
                { "Drama", 5.0}
            }},
            { "Charlie", new Dictionary<string, double>(){
                { "Action", 2.0},
                { "Comedy", 5.0},
                { "Drama", 4.0}
            }},
        };

        string currentUser = "Alice";
        Dictionary<string, double> currentUserPreferences = userPreferences[currentUser];

        Dictionary<string, double> recommendations = new Dictionary<string, double>();
        foreach (var user in userPreferences)
        {
            if (user.Key != currentUser)
            {
                foreach (var genreRating in user.Value)
                {
                    if (!currentUserPreferences.ContainsKey(genreRating.Key))
                    {
                        if (!recommendations.ContainsKey(genreRating.Key))
                        {
                            recommendations.Add(genreRating.Key, genreRating.Value);
                        }
                        else
                        {
                            recommendations[genreRating.Key] += genreRating.Value;
                        }
                    }
                }
            }
        }

        Console.WriteLine("Recommendations for " + currentUser + ":");
        foreach (var recommendation in recommendations)
        {
            Console.WriteLine(recommendation.Key + ": " + recommendation.Value);
        }
    }
}

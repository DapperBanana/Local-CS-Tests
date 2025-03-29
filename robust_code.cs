
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> userPreferences = new Dictionary<string, Dictionary<string, int>>();
        Dictionary<string, Dictionary<string, int>> itemFeatures = new Dictionary<string, Dictionary<string, int>>();

        // Add sample user preferences
        userPreferences.Add("Alice", new Dictionary<string, int> { { "action", 5 }, { "comedy", 3 }, { "drama", 2 } });
        userPreferences.Add("Bob", new Dictionary<string, int> { { "action", 2 }, { "comedy", 4 }, { "drama", 5 } });

        // Add sample item features
        itemFeatures.Add("movie1", new Dictionary<string, int> { { "action", 4 }, { "comedy", 3 }, { "drama", 2 } });
        itemFeatures.Add("movie2", new Dictionary<string, int> { { "action", 1 }, { "comedy", 5 }, { "drama", 4 } });

        // Calculate recommendation scores for each item based on user preferences
        Dictionary<string, double> recommendationScores = new Dictionary<string, double>();
        foreach (var item in itemFeatures)
        {
            double score = 0;
            foreach (var feature in item.Value)
            {
                if (userPreferences["Alice"].ContainsKey(feature.Key))
                {
                    score += userPreferences["Alice"][feature.Key] * feature.Value;
                }
            }
            recommendationScores.Add(item.Key, score);
        }

        // Sort recommendation scores in descending order
        var sortedRecommendations = recommendationScores.OrderByDescending(x => x.Value);

        // Display top recommendations
        foreach (var recommendation in sortedRecommendations)
        {
            Console.WriteLine(recommendation.Key + ": " + recommendation.Value);
        }

    }
}


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // The dataset of items and their features
        Dictionary<string, Dictionary<string, int>> items = new Dictionary<string, Dictionary<string, int>>
        {
            { "item1", new Dictionary<string, int> { { "feature1", 1 }, { "feature2", 0 }, { "feature3", 1 } } },
            { "item2", new Dictionary<string, int> { { "feature1", 0 }, { "feature2", 1 }, { "feature3", 1 } } },
            { "item3", new Dictionary<string, int> { { "feature1", 1 }, { "feature2", 1 }, { "feature3", 0 } } }
        };

        // The user profile of features
        Dictionary<string, int> userProfile = new Dictionary<string, int>
        {
            { "feature1", 1 },
            { "feature2", 1 },
            { "feature3", 0 }
        };

        // Compute the recommendation scores for each item
        Dictionary<string, double> scores = new Dictionary<string, double>();
        foreach (var item in items)
        {
            double score = 0.0;
            foreach (var feature in item.Value)
            {
                score += feature.Value * userProfile[feature.Key];
            }
            scores.Add(item.Key, score);
        }

        // Sort the items by their recommendation scores
        List<string> recommendations = new List<string>(scores.Keys);
        recommendations.Sort((x, y) => scores[y].CompareTo(scores[x]));

        // Display the recommended items
        Console.WriteLine("Recommended items:");
        foreach (var item in recommendations)
        {
            Console.WriteLine(item);
        }
    }
}

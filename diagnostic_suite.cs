
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Define some items and their features
        Dictionary<string, Dictionary<string, int>> items = new Dictionary<string, Dictionary<string, int>>()
        {
            { "item1", new Dictionary<string, int> { { "feature1", 1 }, { "feature2", 0 }, { "feature3", 1 } } },
            { "item2", new Dictionary<string, int> { { "feature1", 0 }, { "feature2", 1 }, { "feature3", 1 } } },
            { "item3", new Dictionary<string, int> { { "feature1", 1 }, { "feature2", 1 }, { "feature3", 0 } } }
        };

        // Define user preferences
        Dictionary<string, int> userPreferences = new Dictionary<string, int>()
        {
            { "feature1", 1 },
            { "feature2", 0 },
            { "feature3", 1 }
        };

        // Calculate item scores based on user preferences
        Dictionary<string, double> itemScores = new Dictionary<string, double>();
        foreach (var item in items)
        {
            double score = 0;
            foreach (var feature in userPreferences)
            {
                if (item.Value.ContainsKey(feature.Key))
                {
                    score += item.Value[feature.Key] * feature.Value;
                }
            }
            itemScores.Add(item.Key, score);
        }

        // Sort items by score in descending order
        var sortedItems = itemScores.OrderByDescending(x => x.Value);

        // Display recommended items
        Console.WriteLine("Recommended items:");
        foreach (var item in sortedItems)
        {
            Console.WriteLine(item.Key);
        }
    }
}

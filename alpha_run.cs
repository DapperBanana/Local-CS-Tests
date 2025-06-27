
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Define content items
        var items = new Dictionary<string, Dictionary<string, double>>
        {
            { "Item1", new Dictionary<string, double> { { "Tag1", 0.8 }, { "Tag2", 0.6 }, { "Tag3", 0.5 } } },
            { "Item2", new Dictionary<string, double> { { "Tag1", 0.9 }, { "Tag2", 0.7 }, { "Tag3", 0.4 } } },
            { "Item3", new Dictionary<string, double> { { "Tag1", 0.7 }, { "Tag2", 0.8 }, { "Tag3", 0.3 } } }
        };

        // Define user preferences
        var userPreferences = new Dictionary<string, double> { { "Tag1", 0.9 }, { "Tag2", 0.7 }, { "Tag3", 0.5 } };

        // Perform content-based recommendation
        var recommendedItems = RecommendItems(items, userPreferences);

        // Display recommended items
        Console.WriteLine("Recommended Items:");
        foreach (var item in recommendedItems)
        {
            Console.WriteLine(item);
        }
    }

    static List<string> RecommendItems(Dictionary<string, Dictionary<string, double>> items, Dictionary<string, double> userPreferences)
    {
        var recommendedItems = new List<string>();

        foreach (var item in items)
        {
            double score = 0;

            foreach (var tag in item.Value)
            {
                if (userPreferences.ContainsKey(tag.Key))
                {
                    score += tag.Value * userPreferences[tag.Key];
                }
            }

            if (score > 0.6) // Threshold for recommendation
            {
                recommendedItems.Add(item.Key);
            }
        }

        return recommendedItems;
    }
}

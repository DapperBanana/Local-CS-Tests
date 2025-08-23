
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> itemFeatures = new Dictionary<string, Dictionary<string, int>>();

        // Add some items and their features
        itemFeatures.Add("Item1", new Dictionary<string, int>
        {
            { "Feature1", 5 },
            { "Feature2", 3 },
            { "Feature3", 2 }
        });

        itemFeatures.Add("Item2", new Dictionary<string, int>
        {
            { "Feature1", 4 },
            { "Feature2", 5 },
            { "Feature3", 1 }
        });

        itemFeatures.Add("Item3", new Dictionary<string, int>
        {
            { "Feature1", 2 },
            { "Feature2", 4 },
            { "Feature3", 3 }
        });

        // Recommend items based on similarities between their features
        string inputItem = "Item1";
        List<string> recommendedItems = new List<string>();

        foreach (var item in itemFeatures)
        {
            if (item.Key != inputItem)
            {
                double similarity = CalculateSimilarity(itemFeatures[inputItem], item.Value);
                if (similarity >= 0.5) // Adjust the threshold as needed
                {
                    recommendedItems.Add(item.Key);
                }
            }
        }

        Console.WriteLine("Recommended items similar to " + inputItem + ":");
        foreach (string recommendedItem in recommendedItems)
        {
            Console.WriteLine(recommendedItem);
        }
    }

    static double CalculateSimilarity(Dictionary<string, int> features1, Dictionary<string, int> features2)
    {
        double dotProduct = 0.0;
        double magnitude1 = 0.0;
        double magnitude2 = 0.0;

        foreach (var feature in features1)
        {
            if (features2.ContainsKey(feature.Key))
            {
                dotProduct += feature.Value * features2[feature.Key];
            }
            magnitude1 += Math.Pow(feature.Value, 2);
        }

        foreach (var feature in features2)
        {
            magnitude2 += Math.Pow(feature.Value, 2);
        }

        magnitude1 = Math.Sqrt(magnitude1);
        magnitude2 = Math.Sqrt(magnitude2);

        if (magnitude1 * magnitude2 == 0)
        {
            return 0.0;
        }
        else
        {
            return dotProduct / (magnitude1 * magnitude2);
        }
    }
}

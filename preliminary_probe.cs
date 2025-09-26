
using System;
using System.Collections.Generic;

class RecommendationSystem
{
    private Dictionary<string, Dictionary<string, double>> data;

    public RecommendationSystem()
    {
        data = new Dictionary<string, Dictionary<string, double>>();
    }

    public void AddItem(string item, Dictionary<string, double> features)
    {
        data[item] = features;
    }

    public List<string> GetRecommendations(string item, int numRecommendations)
    {
        Dictionary<string, double> scores = new Dictionary<string, double>();

        foreach (var otherItem in data.Keys)
        {
            if (otherItem == item) continue;

            double score = CalculateSimilarity(item, otherItem);
            scores[otherItem] = score;
        }

        List<string> recommendations = new List<string>();

        foreach (var kvp in scores.OrderByDescending(x => x.Value).Take(numRecommendations))
        {
            recommendations.Add(kvp.Key);
        }

        return recommendations;
    }

    private double CalculateSimilarity(string item1, string item2)
    {
        Dictionary<string, double> features1 = data[item1];
        Dictionary<string, double> features2 = data[item2];

        double dotProduct = 0;
        double magnitude1 = 0;
        double magnitude2 = 0;

        foreach (var feature in features1.Keys)
        {
            if (features2.ContainsKey(feature))
            {
                dotProduct += features1[feature] * features2[feature];
            }
            magnitude1 += Math.Pow(features1[feature], 2);
        }

        foreach (var feature in features2.Keys)
        {
            magnitude2 += Math.Pow(features2[feature], 2);
        }

        magnitude1 = Math.Sqrt(magnitude1);
        magnitude2 = Math.Sqrt(magnitude2);

        double similarity = dotProduct / (magnitude1 * magnitude2);

        return similarity;
    }
}

class Program
{
    static void Main(string[] args)
    {
        RecommendationSystem system = new RecommendationSystem();

        Dictionary<string, double> movie1Features = new Dictionary<string, double>
        {
            { "Action", 0.9 },
            { "Drama", 0.2 },
            { "Comedy", 0.1 }
        };

        Dictionary<string, double> movie2Features = new Dictionary<string, double>
        {
            { "Action", 0.4 },
            { "Drama", 0.8 },
            { "Comedy", 0.2 }
        };

        Dictionary<string, double> movie3Features = new Dictionary<string, double>
        {
            { "Action", 0.6 },
            { "Drama", 0.4 },
            { "Comedy", 0.3 }
        };

        system.AddItem("Movie1", movie1Features);
        system.AddItem("Movie2", movie2Features);
        system.AddItem("Movie3", movie3Features);

        List<string> recommendations = system.GetRecommendations("Movie1", 2);

        Console.WriteLine("Recommendations for Movie1:");
        foreach (string movie in recommendations)
        {
            Console.WriteLine(movie);
        }
    }
}

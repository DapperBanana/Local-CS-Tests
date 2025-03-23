
using System;
using System.Collections.Generic;

class RecommendationSystem
{
    private Dictionary<string, List<string>> contentMap = new Dictionary<string, List<string>>();

    public RecommendationSystem()
    {
        // Sample data for the recommendation system
        contentMap.Add("Action", new List<string> { "The Dark Knight", "Die Hard", "Mad Max" });
        contentMap.Add("Comedy", new List<string> { "Superbad", "Bridesmaids", "Anchorman" });
        contentMap.Add("Drama", new List<string> { "The Shawshank Redemption", "The Godfather", "Titanic" });
    }

    public List<string> GetRecommendations(string genre)
    {
        if (contentMap.ContainsKey(genre))
        {
            return contentMap[genre];
        }
        else
        {
            return new List<string>();
        }
    }

    public void AddContent(string genre, string content)
    {
        if (contentMap.ContainsKey(genre))
        {
            contentMap[genre].Add(content);
        }
        else
        {
            contentMap.Add(genre, new List<string> { content });
        }
    }

    public static void Main()
    {
        RecommendationSystem recommendationSystem = new RecommendationSystem();

        // Get recommendations for different genres
        List<string> actionRecommendations = recommendationSystem.GetRecommendations("Action");
        List<string> comedyRecommendations = recommendationSystem.GetRecommendations("Comedy");
        List<string> dramaRecommendations = recommendationSystem.GetRecommendations("Drama");

        Console.WriteLine("Action Recommendations:");
        foreach (string recommendation in actionRecommendations)
        {
            Console.WriteLine(recommendation);
        }

        Console.WriteLine("\nComedy Recommendations:");
        foreach (string recommendation in comedyRecommendations)
        {
            Console.WriteLine(recommendation);
        }

        Console.WriteLine("\nDrama Recommendations:");
        foreach (string recommendation in dramaRecommendations)
        {
            Console.WriteLine(recommendation);
        }

        // Add a new movie to the Comedy genre
        recommendationSystem.AddContent("Comedy", "Dumb and Dumber");

        // Get updated Comedy recommendations
        comedyRecommendations = recommendationSystem.GetRecommendations("Comedy");

        Console.WriteLine("\nUpdated Comedy Recommendations:");
        foreach (string recommendation in comedyRecommendations)
        {
            Console.WriteLine(recommendation);
        }
    }
}

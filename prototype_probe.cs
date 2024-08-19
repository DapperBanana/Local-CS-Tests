
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> content = new Dictionary<string, List<string>>()
        {
            { "Action Movies", new List<string> { "Die Hard", "The Dark Knight", "Mad Max: Fury Road" } },
            { "Comedy Movies", new List<string> { "Superbad", "Anchorman", "Bridesmaids" } },
            { "Drama Movies", new List<string> { "The Shawshank Redemption", "Titanic", "Forrest Gump" } }
        };

        string userPreferences = "Action Movies";

        List<string> recommendedContent = RecommendContent(userPreferences, content);

        Console.WriteLine("Recommended content based on user preferences:");
        foreach (var item in recommendedContent)
        {
            Console.WriteLine("- " + item);
        }
    }

    static List<string> RecommendContent(string userPreferences, Dictionary<string, List<string>> content)
    {
        List<string> recommendedContent = new List<string>();

        foreach (var (key, value) in content)
        {
            if (key == userPreferences)
            {
                recommendedContent.AddRange(value);
            }
        }

        return recommendedContent;
    }
}

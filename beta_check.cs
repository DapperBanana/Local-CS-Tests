
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> items = new Dictionary<string, List<string>>();
        
        items.Add("Romance", new List<string>() {"The Notebook", "Pride and Prejudice", "Titanic"});
        items.Add("Action", new List<string>() {"Die Hard", "The Avengers", "Mad Max: Fury Road"});
        items.Add("Comedy", new List<string>() {"Dumb and Dumber", "Superbad", "The Hangover"});
        
        string userGenre = "Romance"; // User's preferred genre
        List<string> recommendedItems = GetRecommendations(userGenre, items);
        
        Console.WriteLine($"Recommended {userGenre} movies:");
        foreach(var item in recommendedItems)
        {
            Console.WriteLine(item);
        }
    }
    
    static List<string> GetRecommendations(string genre, Dictionary<string, List<string>> items)
    {
        List<string> recommendations = new List<string>();
        
        foreach(var kvp in items)
        {
            if(kvp.Key == genre)
            {
                foreach(var item in kvp.Value)
                {
                    recommendations.Add(item);
                }
            }
        }
        
        return recommendations;
    }
}

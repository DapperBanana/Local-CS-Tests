
using System;
using System.Collections.Generic;

class MovieRecommendationSystem
{
    static void Main()
    {
        // Create a dictionary to store movie genres and corresponding movie titles
        Dictionary<string, List<string>> movieDatabase = new Dictionary<string, List<string>>()
        {
            {"Action", new List<string> {"The Dark Knight", "Avengers", "Mad Max: Fury Road"}},
            {"Comedy", new List<string> {"Superbad", "Bridesmaids", "The Hangover"}},
            {"Drama", new List<string> {"The Shawshank Redemption", "Forrest Gump", "Gone Girl"}}
        };

        // Prompt user to enter their preferred genre
        Console.WriteLine("Welcome to the Movie Recommendation System!");
        Console.WriteLine("Please enter your preferred movie genre (Action, Comedy, Drama):");
        string preferredGenre = Console.ReadLine();

        // Display movie recommendations based on user's preferred genre
        if (movieDatabase.ContainsKey(preferredGenre))
        {
            Console.WriteLine("Here are some movie recommendations for you:");
            foreach (string movieTitle in movieDatabase[preferredGenre])
            {
                Console.WriteLine(movieTitle);
            }
        }
        else
        {
            Console.WriteLine("Sorry, there are no movie recommendations available for the selected genre.");
        }
    }
}

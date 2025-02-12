
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List of movie genres
        List<string> genres = new List<string> { "Action", "Comedy", "Drama", "Horror", "Sci-Fi" };

        // Dictionary of recommended movies for each genre
        Dictionary<string, List<string>> recommendations = new Dictionary<string, List<string>>()
        {
            { "Action", new List<string> { "Die Hard", "The Avengers", "Mission: Impossible" } },
            { "Comedy", new List<string> { "Superbad", "Anchorman", "Bridesmaids" } },
            { "Drama", new List<string> { "The Shawshank Redemption", "Forrest Gump", "The Godfather" } },
            { "Horror", new List<string> { "The Shining", "Get Out", "A Quiet Place" } },
            { "Sci-Fi", new List<string> { "Blade Runner", "The Matrix", "Interstellar" } }
        };

        // Display available genres
        Console.WriteLine("Available genres:");
        foreach (string genre in genres)
        {
            Console.WriteLine(genre);
        }

        // Get user input for genre selection
        Console.Write("Enter a genre to get a movie recommendation: ");
        string selectedGenre = Console.ReadLine();

        // Check if selected genre is valid
        if (genres.Contains(selectedGenre))
        {
            // Get recommended movies for selected genre
            List<string> movies = recommendations[selectedGenre];
            
            // Display recommended movies
            Console.WriteLine($"\nRecommended movies for {selectedGenre}:");
            foreach (string movie in movies)
            {
                Console.WriteLine(movie);
            }
        }
        else
        {
            Console.WriteLine("Invalid genre selection. Please try again.");
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Movie Recommendation System!");

        string[] genres = { "Action", "Comedy", "Drama", "Horror", "Sci-Fi" };

        Console.WriteLine("Choose a genre:");
        for (int i = 0; i < genres.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {genres[i]}");
        }

        int choice;
        do
        {
            Console.Write("Enter your choice: ");
        } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > genres.Length);

        string selectedGenre = genres[choice - 1];

        string[] recommendations = GetRecommendations(selectedGenre);

        Console.WriteLine($"\nHere are some {selectedGenre} movie recommendations:");
        foreach (var recommendation in recommendations)
        {
            Console.WriteLine($"- {recommendation}");
        }
    }

    static string[] GetRecommendations(string genre)
    {
        string[] actionMovies = { "The Dark Knight", "Inception", "Mad Max: Fury Road" };
        string[] comedyMovies = { "Superbad", "The Hangover", "Bridesmaids" };
        string[] dramaMovies = { "The Shawshank Redemption", "Forrest Gump", "The Godfather" };
        string[] horrorMovies = { "The Exorcist", "Get Out", "Hereditary" };
        string[] sciFiMovies = { "Blade Runner 2049", "Interstellar", "The Matrix" };

        switch (genre)
        {
            case "Action":
                return actionMovies;
            case "Comedy":
                return comedyMovies;
            case "Drama":
                return dramaMovies;
            case "Horror":
                return horrorMovies;
            case "Sci-Fi":
                return sciFiMovies;
            default:
                return new string[0];
        }
    }
}

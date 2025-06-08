
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Movie Recommendation System!");
        Console.WriteLine("Please answer the following questions to get a movie recommendation.");

        Console.WriteLine("What is your favorite genre of movies? (Action, Drama, Comedy, Horror)");
        string genre = Console.ReadLine();

        Console.WriteLine("Do you prefer newer or older movies?");
        string agePreference = Console.ReadLine();

        Console.WriteLine("Are you in the mood for a classic or something more recent?");
        string timePeriod = Console.ReadLine();

        string recommendedMovie = GetRecommendedMovie(genre, agePreference, timePeriod);

        Console.WriteLine($"Based on your preferences, we recommend you watch: {recommendedMovie}");
    }

    static string GetRecommendedMovie(string genre, string agePreference, string timePeriod)
    {
        if (timePeriod == "classic")
        {
            if (genre == "Action")
            {
                return "Die Hard";
            }
            else if (genre == "Drama")
            {
                return "The Godfather";
            }
            else if (genre == "Comedy")
            {
                return "Some Like It Hot";
            }
            else if (genre == "Horror")
            {
                return "Psycho";
            }
        }
        else
        {
            if (genre == "Action")
            {
                return "Mad Max: Fury Road";
            }
            else if (genre == "Drama")
            {
                return "The Shawshank Redemption";
            }
            else if (genre == "Comedy")
            {
                return "Superbad";
            }
            else if (genre == "Horror")
            {
                return "Get Out";
            }
        }

        return "Sorry, we couldn't find a movie recommendation based on your preferences.";
    }
}

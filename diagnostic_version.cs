
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create sample data of users and their preferences
        Dictionary<string, Dictionary<string, int>> usersPreferences = new Dictionary<string, Dictionary<string, int>>()
        {
            { "User1", new Dictionary<string, int> { { "Movie1", 5 }, { "Movie2", 3 }, { "Movie3", 2 } } },
            { "User2", new Dictionary<string, int> { { "Movie1", 4 }, { "Movie2", 2 }, { "Movie3", 5 } } },
            { "User3", new Dictionary<string, int> { { "Movie1", 2 }, { "Movie2", 4 }, { "Movie3", 3 } } }
        };

        // Recommend movies to User1 based on their preferences
        RecommendMovies("User1", usersPreferences);
    }

    static void RecommendMovies(string user, Dictionary<string, Dictionary<string, int>> usersPreferences)
    {
        Dictionary<string, double> movieScores = new Dictionary<string, double>();
        Dictionary<string, int> userPreferences = usersPreferences[user];

        foreach (var otherUser in usersPreferences)
        {
            if (otherUser.Key != user)
            {
                foreach (var movie in otherUser.Value)
                {
                    if (!userPreferences.ContainsKey(movie.Key))
                    {
                        if (!movieScores.ContainsKey(movie.Key))
                        {
                            movieScores[movie.Key] = 0;
                        }

                        movieScores[movie.Key] += movie.Value;
                    }
                }
            }
        }

        Console.WriteLine($"Recommended movies for {user}:");
        foreach (var movie in movieScores)
        {
            Console.WriteLine($"{movie.Key} - {movie.Value}");
        }
    }
}

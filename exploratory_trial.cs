
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Sample data for movies and user preferences
        var movies = new Dictionary<string, Dictionary<string, int>>
        {
            {"Movie1", new Dictionary<string, int> {{"Action", 5}, {"Comedy", 3}, {"Drama", 2}}},
            {"Movie2", new Dictionary<string, int> {{"Action", 4}, {"Comedy", 2}, {"Drama", 3}}},
            {"Movie3", new Dictionary<string, int> {{"Action", 2}, {"Comedy", 4}, {"Drama", 5}}},
        };

        var userPreferences = new Dictionary<string, int>
        {
            {"Action", 5},
            {"Comedy", 3},
            {"Drama", 2}
        };

        // Calculate similarity scores between movies and user preferences using cosine similarity
        var scores = new Dictionary<string, double>();
        foreach (var movie in movies)
        {
            double dotProduct = 0;
            double magnitudeMovie = 0;
            double magnitudeUser = 0;

            foreach (var genre in userPreferences)
            {
                if (movie.Value.ContainsKey(genre.Key))
                {
                    dotProduct += movie.Value[genre.Key] * genre.Value;
                    magnitudeMovie += Math.Pow(movie.Value[genre.Key], 2);
                    magnitudeUser += Math.Pow(genre.Value, 2);
                }
            }

            double magnitude = Math.Sqrt(magnitudeMovie) * Math.Sqrt(magnitudeUser);
            scores.Add(movie.Key, dotProduct / magnitude);
        }

        // Sort movies by similarity scores
        var sortedMovies = scores.OrderByDescending(x => x.Value);

        // Display recommended movies
        foreach (var movie in sortedMovies)
        {
            Console.WriteLine($"Recommended movie: {movie.Key}, Similarity score: {movie.Value}");
        }
    }
}

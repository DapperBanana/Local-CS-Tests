
using System;
using System.Collections.Generic;

namespace MovieRecommendationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> movies = new Dictionary<string, List<string>>();

            movies.Add("Action", new List<string> { "Die Hard", "John Wick", "The Dark Knight" });
            movies.Add("Comedy", new List<string> { "Superbad", "Dumb and Dumber", "Anchorman" });
            movies.Add("Drama", new List<string> { "The Shawshank Redemption", "The Godfather", "Forrest Gump" });
            movies.Add("Sci-Fi", new List<string> { "Blade Runner", "Interstellar", "The Matrix" });

            Console.WriteLine("Welcome to the Movie Recommendation System!");
            Console.WriteLine("Choose a genre to get a movie recommendation:");
            Console.WriteLine("1. Action");
            Console.WriteLine("2. Comedy");
            Console.WriteLine("3. Drama");
            Console.WriteLine("4. Sci-Fi");

            string choice = Console.ReadLine();

            if (movies.ContainsKey(choice))
            {
                Random random = new Random();
                int index = random.Next(0, movies[choice].Count);
                string recommendedMovie = movies[choice][index];

                Console.WriteLine($"We recommend you watch: {recommendedMovie}");
            }
            else
            {
                Console.WriteLine("Invalid selection. Please choose a valid genre.");
            }
        }
    }
}

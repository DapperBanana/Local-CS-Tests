
using System;
using System.Collections.Generic;

class Movie
{
    public string Title { get; set; }
    public string Genre { get; set; }

    public Movie(string title, string genre)
    {
        Title = title;
        Genre = genre;
    }
}

class Program
{
    static void Main()
    {
        List<Movie> movies = new List<Movie>()
        {
            new Movie("The Shawshank Redemption", "Drama"),
            new Movie("The Godfather", "Crime"),
            new Movie("The Dark Knight", "Action"),
            new Movie("Forrest Gump", "Drama"),
            new Movie("Pulp Fiction", "Crime"),
            new Movie("Inception", "Sci-Fi"),
            new Movie("The Matrix", "Sci-Fi"),
            new Movie("Titanic", "Romance"),
            new Movie("Inglourious Basterds", "Action"),
            new Movie("The Silence of the Lambs", "Thriller")
        };

        Console.WriteLine("Welcome to the Movie Recommendation System!");

        while (true)
        {
            Console.WriteLine("\nEnter a genre to get a movie recommendation or 'exit' to quit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Thank you for using the Movie Recommendation System!");
                break;
            }

            List<Movie> recommendedMovies = movies.FindAll(movie => movie.Genre.Equals(input, StringComparison.OrdinalIgnoreCase));

            if (recommendedMovies.Count > 0)
            {
                Console.WriteLine("\nHere are some recommended movies in the " + input + " genre:");
                foreach (Movie movie in recommendedMovies)
                {
                    Console.WriteLine(movie.Title);
                }
            } 
            else
            {
                Console.WriteLine("No movies were found in the " + input + " genre. Please try a different genre.");
            }
        }
    }
}

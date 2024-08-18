
using System;
using System.Collections.Generic;

class Movie
{
    public string Title { get; set; }
    public List<string> Genres { get; set; }

    public Movie(string title, List<string> genres)
    {
        Title = title;
        Genres = genres;
    }
}

class Program
{
    static void Main()
    {
        List<Movie> movies = new List<Movie>
        {
            new Movie("The Dark Knight", new List<string> { "Action", "Crime", "Thriller" }),
            new Movie("Inception", new List<string> { "Action", "Adventure", "Sci-Fi" }),
            new Movie("The Shawshank Redemption", new List<string> { "Drama" }),
            new Movie("Interstellar", new List<string> { "Adventure", "Drama", "Sci-Fi" }),
            new Movie("Pulp Fiction", new List<string> { "Crime", "Drama" }),
            new Movie("The Matrix", new List<string> { "Action", "Sci-Fi" })
        };

        Console.WriteLine("Enter your favorite movie genre:");
        string inputGenre = Console.ReadLine();

        List<Movie> recommendedMovies = new List<Movie>();
        foreach (Movie movie in movies)
        {
            if (movie.Genres.Contains(inputGenre))
            {
                recommendedMovies.Add(movie);
            }
        }

        if (recommendedMovies.Count > 0)
        {
            Console.WriteLine("Recommended movies based on your input genre:");
            foreach (Movie movie in recommendedMovies)
            {
                Console.WriteLine(movie.Title);
            }
        }
        else
        {
            Console.WriteLine("No recommended movies found for input genre.");
        }
    }
}

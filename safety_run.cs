
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
        List<Movie> movies = new List<Movie>
        {
            new Movie("The Shawshank Redemption", "Drama"),
            new Movie("The Godfather", "Crime"),
            new Movie("Pulp Fiction", "Crime"),
            new Movie("The Dark Knight", "Action"),
            new Movie("Forrest Gump", "Drama")
        };

        Console.WriteLine("Welcome to the Movie Recommendation System!");

        Console.WriteLine("Enter your favorite genre (Drama, Crime, Action):");
        string userGenre = Console.ReadLine();

        List<Movie> recommendedMovies = new List<Movie>();
        foreach (Movie movie in movies)
        {
            if (movie.Genre == userGenre)
            {
                recommendedMovies.Add(movie);
            }
        }

        if (recommendedMovies.Count == 0)
        {
            Console.WriteLine("Sorry, we don't have any recommendations for that genre.");
        }
        else
        {
            Console.WriteLine("Recommended movies in the " + userGenre + " genre:");
            foreach (Movie recommendedMovie in recommendedMovies)
            {
                Console.WriteLine(recommendedMovie.Title);
            }
        }

        Console.WriteLine("Thank you for using the Movie Recommendation System!");
    }
}

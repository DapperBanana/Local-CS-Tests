
using System;

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

class MovieRecommendationSystem
{
    private static Movie[] movies = new Movie[]
    {
        new Movie("The Shawshank Redemption", "Drama"),
        new Movie("The Godfather", "Crime"),
        new Movie("The Dark Knight", "Action"),
        new Movie("Forrest Gump", "Drama"),
        new Movie("Pulp Fiction", "Crime"),
    };

    public static void RecommendMovie(string genre)
    {
        foreach (Movie movie in movies)
        {
            if (movie.Genre.ToLower() == genre.ToLower())
            {
                Console.WriteLine($"We recommend the movie: {movie.Title}");
                return;
            }
        }

        Console.WriteLine("Sorry, we don't have any recommendations for that genre.");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Movie Recommendation System!");
        Console.WriteLine("Please enter a genre to get a movie recommendation:");
        string genre = Console.ReadLine();

        RecommendMovie(genre);

        Console.WriteLine("Thank you for using the Movie Recommendation System!");
    }
}

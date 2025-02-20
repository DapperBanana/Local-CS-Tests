
using System;

class Program
{
    static void Main()
    {
        string[] movies = { "The Shawshank Redemption", "The Godfather", "The Dark Knight", "Pulp Fiction", "Schindler's List" };

        Console.WriteLine("Welcome to the Movie Recommendation System!");
        Console.WriteLine("Here are some popular movies:");

        for (int i = 0; i < movies.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {movies[i]}");
        }

        Console.WriteLine("Enter the number of the movie you like:");
        int userInput = Convert.ToInt32(Console.ReadLine());

        if(userInput >= 1 && userInput <= movies.Length)
        {
            Console.WriteLine($"You might also like these movies: ");
            foreach (string movie in movies)
            {
                if (movie != movies[userInput - 1])
                {
                    Console.WriteLine(movie);
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and " + movies.Length);
        }
    }
}

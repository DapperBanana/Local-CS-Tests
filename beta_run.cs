
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Movie Recommendation System!");

        Console.WriteLine("Please provide some information to help us recommend a movie for you:");

        Console.Write("Enter your favorite movie genre: ");
        string genre = Console.ReadLine();

        Console.Write("Enter your preferred movie release year: ");
        int releaseYear = int.Parse(Console.ReadLine());

        Console.Write("Enter your preferred movie language: ");
        string language = Console.ReadLine();

        Console.WriteLine($"Based on your preferences, we recommend the following movie:");

        if (genre.ToLower() == "action" && releaseYear >= 2000 && language.ToLower() == "english")
        {
            Console.WriteLine("Fast & Furious");
        }
        else if (genre.ToLower() == "comedy" && releaseYear >= 2010 && language.ToLower() == "english")
        {
            Console.WriteLine("The Hangover");
        }
        else if (genre.ToLower() == "drama" && releaseYear >= 2015 && language.ToLower() == "english")
        {
            Console.WriteLine("The Social Network");
        }
        else
        {
            Console.WriteLine("Sorry, we could not find a suitable recommendation for your preferences.");
        }
    }
}

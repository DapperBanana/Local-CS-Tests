
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Recipe Recommendation System!");

        // Gather user input
        Console.WriteLine("What type of dish are you in the mood for? (e.g. Italian, Mexican, Asian)");
        string cuisine = Console.ReadLine();

        // Recommend recipe based on user input
        switch (cuisine.ToLower())
        {
            case "italian":
                Console.WriteLine("We recommend trying a classic Spaghetti Bolognese recipe!");
                break;
            case "mexican":
                Console.WriteLine("How about making some delicious Chicken Enchiladas?");
                break;
            case "asian":
                Console.WriteLine("You might enjoy cooking a tasty Chicken Teriyaki stir-fry!");
                break;
            default:
                Console.WriteLine("Sorry, we don't have any recommendations for that cuisine.");
                break;
        }

        Console.WriteLine("Enjoy your cooking!");
    }
}

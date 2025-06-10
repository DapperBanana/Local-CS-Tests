
using System;

class RecipeRecommendationSystem
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Recipe Recommendation System!");

        Console.WriteLine("What type of dish are you in the mood for? (e.g. Italian, Mexican, Asian)");
        string cuisine = Console.ReadLine();

        // Recommend recipes based on the user's input
        if (cuisine.ToLower() == "italian")
        {
            Console.WriteLine("How about trying a classic Spaghetti Carbonara?");
        }
        else if (cuisine.ToLower() == "mexican")
        {
            Console.WriteLine("You might enjoy making some Chicken Enchiladas!");
        }
        else if (cuisine.ToLower() == "asian")
        {
            Console.WriteLine("Why not try making a delicious Stir-fried Noodles?");
        }
        else
        {
            Console.WriteLine("Sorry, we don't have any recommendations for that cuisine.");
        }

        Console.WriteLine("Enjoy your meal!");
    }
}

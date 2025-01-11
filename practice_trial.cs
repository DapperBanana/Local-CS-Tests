
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Recipe Recommendation System!");
        
        Console.WriteLine("What are you in the mood for? (breakfast, lunch, dinner):");
        string mealType = Console.ReadLine().ToLower();

        if (mealType == "breakfast")
        {
            Console.WriteLine("May I recommend trying out a classic scrambled eggs with toast recipe?");
        }
        else if (mealType == "lunch")
        {
            Console.WriteLine("How about a delicious chicken avocado salad?");
        }
        else if (mealType == "dinner")
        {
            Console.WriteLine("You should try making a tasty spaghetti bolognese for dinner tonight!");
        }
        else
        {
            Console.WriteLine("Sorry, we don't have a recommendation for that meal type. Try again with either breakfast, lunch, or dinner.");
        }
    }
}

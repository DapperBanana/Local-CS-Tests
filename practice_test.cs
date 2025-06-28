
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Recipe Recommendation System!");
        
        Console.WriteLine("Enter your preferences (e.g. vegetarian, gluten-free, dairy-free):");
        string preferences = Console.ReadLine().ToLower();
        
        string recommendedRecipe = GetRecommendedRecipe(preferences);
        
        if (recommendedRecipe != "")
        {
            Console.WriteLine("We recommend trying the following recipe:");
            Console.WriteLine(recommendedRecipe);
        }
        else
        {
            Console.WriteLine("Sorry, we couldn't find a recipe that matches your preferences.");
        }
    }
    
    static string GetRecommendedRecipe(string preferences)
    {
        if (preferences.Contains("vegetarian"))
        {
            return "Vegetable stir-fry with tofu";
        }
        else if (preferences.Contains("gluten-free"))
        {
            return "Quinoa salad with roasted veggies";
        }
        else if (preferences.Contains("dairy-free"))
        {
            return "Coconut curry with chickpeas";
        }
        
        return "";
    }
}

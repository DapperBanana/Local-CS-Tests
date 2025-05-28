
using System;
using System.Collections.Generic;

class RecipeRecommendationSystem
{
    static void Main(string[] args)
    {
        // Create a dictionary of recipes with their ingredients
        Dictionary<string, List<string>> recipes = new Dictionary<string, List<string>>
        {
            { "Spaghetti Bolognese", new List<string> { "spaghetti", "tomato sauce", "ground beef", "onion", "garlic" } },
            { "Chicken Alfredo", new List<string> { "fettuccine", "alfredo sauce", "chicken breast", "garlic", "butter" } },
            { "Vegetable Stir Fry", new List<string> { "mixed vegetables", "soy sauce", "garlic", "ginger", "vegetable oil" } }
        };

        // Ask user for their available ingredients
        Console.WriteLine("Enter the ingredients you have available (separated by commas):");
        string userInput = Console.ReadLine();
        List<string> userIngredients = new List<string>(userInput.Split(','));

        // Find recipes that can be made with the user's ingredients
        List<string> recommendedRecipes = new List<string>();
        foreach (var recipe in recipes)
        {
            bool canMakeRecipe = true;
            foreach (var ingredient in recipe.Value)
            {
                if (!userIngredients.Contains(ingredient))
                {
                    canMakeRecipe = false;
                    break;
                }
            }
            if (canMakeRecipe)
            {
                recommendedRecipes.Add(recipe.Key);
            }
        }

        // Display recommended recipes
        if (recommendedRecipes.Count > 0)
        {
            Console.WriteLine("Recommended recipes that you can make:");
            foreach (var recipe in recommendedRecipes)
            {
                Console.WriteLine(recipe);
            }
        }
        else
        {
            Console.WriteLine("Sorry, you don't have enough ingredients to make any recipe.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Initialize recipes
        var recipes = new List<Recipe>
        {
            new Recipe("Pasta Carbonara", new List<string> { "pasta", "egg", "cheese", "bacon", "black pepper" }),
            new Recipe("Vegetable Stir Fry", new List<string> { "broccoli", "carrot", "bell pepper", "soy sauce", "garlic" }),
            new Recipe("Tomato Soup", new List<string> { "tomato", "onion", "garlic", "basil", "vegetable broth" }),
            new Recipe("Grilled Cheese Sandwich", new List<string> { "bread", "cheese", "butter" }),
            new Recipe("Chicken Salad", new List<string> { "chicken", "lettuce", "tomato", "cucumber", "mayonnaise" })
        };

        Console.WriteLine("Welcome to the Recipe Recommendation System!");
        Console.WriteLine("Please enter the ingredients you have, separated by commas:");
        Console.Write("> ");
        var input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("No ingredients entered. Exiting.");
            return;
        }

        var userIngredients = input.ToLower().Split(',').Select(i => i.Trim()).Where(i => !string.IsNullOrEmpty(i)).ToHashSet();

        var recommendedRecipes = recipes
            .Select(r => new { Recipe = r, MatchCount = r.Ingredients.Intersect(userIngredients).Count() })
            .Where(r => r.MatchCount > 0)
            .OrderByDescending(r => r.MatchCount)
            .ToList();

        if (recommendedRecipes.Count == 0)
        {
            Console.WriteLine("Sorry, no recipes match your ingredients.");
        }
        else
        {
            Console.WriteLine("\nRecipes you can make with your ingredients:");
            foreach (var r in recommendedRecipes)
            {
                Console.WriteLine($"- {r.Recipe.Name} (using {r.MatchCount} of your ingredients)");
            }
        }
    }
}

class Recipe
{
    public string Name { get; set; }
    public List<string> Ingredients { get; set; }

    public Recipe(string name, List<string> ingredients)
    {
        Name = name;
        Ingredients = ingredients.Select(i => i.ToLower()).ToList();
    }
}
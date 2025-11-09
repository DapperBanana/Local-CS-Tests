
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Recipe Recommendation System!");
        Console.WriteLine("Please answer the following questions to get a recipe recommendation.");
        Console.WriteLine();

        Console.Write("Are you in the mood for something sweet or savory? (sweet/savory): ");
        string category = Console.ReadLine();

        Console.Write("Do you have any dietary restrictions? (yes/no): ");
        string dietaryRestrictions = Console.ReadLine();

        if (category == "sweet")
        {
            if (dietaryRestrictions == "yes")
            {
                Console.WriteLine("I recommend trying a fruit salad with honey and nuts!");
            }
            else
            {
                Console.WriteLine("I recommend trying a classic chocolate chip cookie recipe!");
            }
        }
        else if (category == "savory")
        {
            if (dietaryRestrictions == "yes")
            {
                Console.WriteLine("I recommend trying a vegetable stir-fry with tofu!");
            }
            else
            {
                Console.WriteLine("I recommend trying a homemade pizza with your favorite toppings!");
            }
        }
        else
        {
            Console.WriteLine("Sorry, I couldn't find a recipe that matches your preferences.");
        }

        Console.WriteLine("Enjoy your meal!");
    }
}

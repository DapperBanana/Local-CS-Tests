
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Recipe Recommendation System!");
        
        Console.WriteLine("What type of dish are you looking to make? (e.g. pasta, salad, curry)");
        string dishType = Console.ReadLine().ToLower();

        switch (dishType)
        {
            case "pasta":
                Console.WriteLine("I recommend making a classic Spaghetti Aglio e Olio!");
                break;
            case "salad":
                Console.WriteLine("I recommend making a Caesar Salad!");
                break;
            case "curry":
                Console.WriteLine("I recommend making a Chicken Tikka Masala!");
                break;
            default:
                Console.WriteLine("I'm sorry, I do not have a recommendation for that dish type.");
                break;
        }
    }
}

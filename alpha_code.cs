
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Movie Recommendation System!");
        
        Console.WriteLine("Please rate the following movies on a scale of 1 to 5:");
        
        Console.Write("How much did you like 'The Shawshank Redemption'? ");
        int shawshankRating = int.Parse(Console.ReadLine());
        
        Console.Write("How much did you like 'The Godfather'? ");
        int godfatherRating = int.Parse(Console.ReadLine());
        
        Console.Write("How much did you like 'The Dark Knight'? ");
        int darkKnightRating = int.Parse(Console.ReadLine());
        
        int totalRating = shawshankRating + godfatherRating + darkKnightRating;
        
        if (totalRating >= 13)
        {
            Console.WriteLine("Based on your ratings, we recommend you watch 'Inception'.");
        }
        else if (totalRating >= 9)
        {
            Console.WriteLine("Based on your ratings, we recommend you watch 'Pulp Fiction'.");
        }
        else
        {
            Console.WriteLine("Based on your ratings, we recommend you watch 'The Matrix'.");
        }
    }
}

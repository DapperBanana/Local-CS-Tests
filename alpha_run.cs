
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Movie Recommendation System!");

        while (true)
        {
            Console.WriteLine("\nWhat genre are you in the mood for?");
            Console.WriteLine("1. Action");
            Console.WriteLine("2. Comedy");
            Console.WriteLine("3. Drama");
            Console.WriteLine("4. Horror");
            Console.WriteLine("5. Sci-Fi");
            Console.Write("Enter the number of your choice: ");

            string input = Console.ReadLine();
            int choice;
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("I recommend watching 'Die Hard' or 'Mad Max: Fury Road'.");
                        break;
                    case 2:
                        Console.WriteLine("I recommend watching 'Superbad' or 'The Hangover'.");
                        break;
                    case 3:
                        Console.WriteLine("I recommend watching 'The Shawshank Redemption' or 'The Godfather'.");
                        break;
                    case 4:
                        Console.WriteLine("I recommend watching 'The Exorcist' or 'Get Out'.");
                        break;
                    case 5:
                        Console.WriteLine("I recommend watching 'Blade Runner' or 'Interstellar'.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.WriteLine("\nWould you like to get another recommendation? (Y/N)");
            string response = Console.ReadLine();
            if (response.ToLower() != "y")
            {
                break;
            }
        }

        Console.WriteLine("Thank you for using the Movie Recommendation System. Enjoy your movie!");
    }
}

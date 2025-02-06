
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter a URL: ");
        string input = Console.ReadLine();

        if (IsValidURL(input))
        {
            Console.WriteLine("Valid URL.");
        }
        else
        {
            Console.WriteLine("Invalid URL.");
        }
    }

    static bool IsValidURL(string input)
    {
        string urlPattern = @"^(https?://)?([\da-z.-]+)\.([a-z.]{2,6})([/\w .-]*)*/?$";
        Regex regex = new Regex(urlPattern, RegexOptions.IgnoreCase);

        return regex.IsMatch(input);
    }
}


using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a URL:");
        string input = Console.ReadLine();

        if (IsValidUrl(input))
        {
            Console.WriteLine("Valid URL");
        }
        else
        {
            Console.WriteLine("Invalid URL");
        }
    }

    static bool IsValidUrl(string url)
    {
        string pattern = @"^(https?://)?([\da-z\.-]+)\.([a-z\.]{2,6})([/\w\.-]*)*/?$";
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

        return regex.IsMatch(url);
    }
}

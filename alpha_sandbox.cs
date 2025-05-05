
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputURL = "https://www.example.com";

        if (IsValidURL(inputURL))
        {
            Console.WriteLine("The given string is a valid URL.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid URL.");
        }
    }

    static bool IsValidURL(string url)
    {
        // Regular expression pattern for URL validation
        string pattern = @"^(https?://)?([a-z0-9-]+\.)+[a-z]{2,6}(/.*)?$";

        // Create a Regex object with the pattern
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

        // Match the input URL against the pattern
        return regex.IsMatch(url);
    }
}

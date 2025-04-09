
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input;

        Console.Write("Enter a URL: ");
        input = Console.ReadLine();

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
        string pattern = @"^(https?|ftp|file)://[-a-zA-Z0-9+&@#/%?=~_|!:,.;]*[-a-zA-Z0-9+&@#/%=~_|]";
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

        return regex.IsMatch(url);
    }
}

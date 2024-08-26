
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "https://www.example.com";

        if (IsUrlValid(input))
        {
            Console.WriteLine("The URL is valid.");
        }
        else
        {
            Console.WriteLine("The URL is invalid.");
        }
    }

    static bool IsUrlValid(string url)
    {
        // Regular expression pattern for a valid URL
        string pattern = @"^(https?|ftp)://([\w-]+.)+[\w-]+(/[\w-./?%&=]*)?$";

        // Check if the input matches the pattern
        return Regex.IsMatch(url, pattern);
    }
}


using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "https://www.example.com";

        if (IsValidUrl(input))
        {
            Console.WriteLine("URL is valid.");
        }
        else
        {
            Console.WriteLine("URL is not valid.");
        }
    }

    static bool IsValidUrl(string url)
    {
        string pattern = @"^(http|https)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$";
        Regex regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        return regex.IsMatch(url);
    }
}

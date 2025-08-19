
using System;
using System.Text.RegularExpressions;

class Program
{
    static bool IsValidUrl(string url)
    {
        if (string.IsNullOrEmpty(url))
        {
            return false;
        }

        string pattern = @"^(http(s)?://)?([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$";

        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
        return regex.IsMatch(url);
    }

    static void Main()
    {
        string url = "https://www.example.com";

        Console.WriteLine("Checking if URL is valid:");
        Console.WriteLine(url);

        if (IsValidUrl(url))
        {
            Console.WriteLine("The URL is valid.");
        }
        else
        {
            Console.WriteLine("The URL is not valid.");
        }
    }
}

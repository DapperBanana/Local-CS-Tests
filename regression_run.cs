
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "https://www.example.com";

        bool isValidUrl = IsValidUrl(input);

        if (isValidUrl)
        {
            Console.WriteLine("The input is a valid URL.");
        }
        else
        {
            Console.WriteLine("The input is not a valid URL.");
        }
    }

    static bool IsValidUrl(string url)
    {
        string pattern = @"^(http|https)://([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$";
        Regex regex = new Regex(pattern);

        return regex.IsMatch(url);
    }
}

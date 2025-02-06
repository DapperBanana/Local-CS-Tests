
using System;
using System.Text.RegularExpressions;

class Program
{
    public static bool IsValidUrl(string url)
    {
        string pattern = @"^(https?://)?([a-z0-9-]+\.)+[a-z]{2,}$";
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
        return regex.IsMatch(url);
    }

    static void Main()
    {
        string url = "https://www.example.com";
        bool isValid = IsValidUrl(url);

        if (isValid)
        {
            Console.WriteLine("The URL is valid.");
        }
        else
        {
            Console.WriteLine("The URL is not valid.");
        }
    }
}

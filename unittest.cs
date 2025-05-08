
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputUrl = "https://www.example.com";
        
        bool isValidUrl = IsValidUrl(inputUrl);
        
        if (isValidUrl)
        {
            Console.WriteLine("The URL is valid.");
        }
        else
        {
            Console.WriteLine("The URL is invalid.");
        }
    }

    static bool IsValidUrl(string url)
    {
        string pattern = @"^(https?|ftp)://[\w.-]+(/\w+)*$";
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
        
        return regex.IsMatch(url);
    }
}

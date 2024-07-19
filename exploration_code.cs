
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputUrl = "https://www.example.com";
        
        if (IsValidUrl(inputUrl))
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
        Regex regex = new Regex(@"\b(?:https?|ftp|file)://[-a-zA-Z0-9+&@#/%?=~_|!:,.;]*[-a-zA-Z0-9+&@#/%=~_|]");
        return regex.IsMatch(url);
    }
}

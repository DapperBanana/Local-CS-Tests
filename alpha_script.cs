
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
            Console.WriteLine("The input URL is valid.");
        }
        else
        {
            Console.WriteLine("The input URL is not valid.");
        }
    }

    static bool IsValidUrl(string url)
    {
        string pattern = @"^(https?|ftp)://[^\s/$.?#].[^\s]*$";
        Regex regex = new Regex(pattern);

        return regex.IsMatch(url);
    }
}

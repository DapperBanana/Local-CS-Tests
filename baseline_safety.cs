
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
        string pattern = @"^(https?://)?([a-zA-Z0-9-]+\.)*[a-zA-Z]{2,}(:\d{1,5})?(/.*)?$";
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

        return regex.IsMatch(url);
    }
}

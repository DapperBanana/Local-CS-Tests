
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputUrl = "https://www.example.com";

        if (IsValidUrl(inputUrl))
        {
            Console.WriteLine("The given URL is valid.");
        }
        else
        {
            Console.WriteLine("The given URL is not valid.");
        }
    }

    static bool IsValidUrl(string url)
    {
        string pattern = @"^(https?://)?([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,}(/\S*)?$";

        Regex regex = new Regex(pattern);

        return regex.IsMatch(url);
    }
}

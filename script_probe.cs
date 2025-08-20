
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "https://www.example.com";

        if (IsValidUrl(input))
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
        string pattern = @"^(https?|ftp):\/\/[^\s/$.?#].[^\s]*$";
        
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
        
        return regex.IsMatch(url);
    }
}

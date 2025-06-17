
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "http://www.example.com";
        
        if (IsValidUrl(input))
        {
            Console.WriteLine("The input string is a valid URL.");
        }
        else
        {
            Console.WriteLine("The input string is not a valid URL.");
        }
    }

    static bool IsValidUrl(string url)
    {
        Regex urlRegex = new Regex(@"^(https?|ftp)://[^\s/$.?#].[^\s]*$");
        return urlRegex.IsMatch(url);
    }
}


using System;

class Program
{
    static void Main()
    {
        string inputUrl = "https://www.example.com";
        
        if (IsValidUrl(inputUrl))
        {
            Console.WriteLine("The given string is a valid URL.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid URL.");
        }
    }

    static bool IsValidUrl(string url)
    {
        return Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute);
    }
}

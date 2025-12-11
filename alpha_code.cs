using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to check if it's a valid URL:");
        string input = Console.ReadLine();

        if (IsValidUrl(input))
        {
            Console.WriteLine("The string is a valid URL.");
        }
        else
        {
            Console.WriteLine("The string is not a valid URL.");
        }
    }

    static bool IsValidUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
            return false;

        return Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult)
               && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
    }
}
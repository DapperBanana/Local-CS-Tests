
using System;

class Program
{
    static void Main()
    {
        string url = "https://example.com";
        
        bool isValidUrl = IsValidUrl(url);
        
        if(isValidUrl)
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
        Uri result;
        return Uri.TryCreate(url, UriKind.Absolute, out result)
               && (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps);
    }
}

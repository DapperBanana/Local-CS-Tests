
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string url = "https://www.example.com";
        
        bool isValidUrl = IsValidUrl(url);
        
        if(isValidUrl)
        {
            Console.WriteLine($"{url} is a valid URL.");
        }
        else
        {
            Console.WriteLine($"{url} is not a valid URL.");
        }
    }

    static bool IsValidUrl(string url)
    {
        string pattern = @"^(https?://)?([0-9a-zA-Z\.-]+)\.([a-zA-Z]{2,6})(:[0-9]{1,5})?(/.*)?$";

        Regex regex = new Regex(pattern);

        return regex.IsMatch(url);
    }
}

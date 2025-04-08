
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "https://www.example.com";

        if (IsValidURL(input))
        {
            Console.WriteLine("The input is a valid URL.");
        }
        else
        {
            Console.WriteLine("The input is not a valid URL.");
        }
    }

    static bool IsValidURL(string url)
    {
        string pattern = @"^(https?|ftp)://[\w.-]+(\.[\w.-]+)+[/#?]?.*$";
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

        return regex.IsMatch(url);
    }
}

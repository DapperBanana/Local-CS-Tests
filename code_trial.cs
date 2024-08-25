
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter a URL: ");
        string input = Console.ReadLine();

        if (IsValidUrl(input))
        {
            Console.WriteLine("The entered URL is valid.");
        }
        else
        {
            Console.WriteLine("The entered URL is not valid.");
        }
    }

    static bool IsValidUrl(string url)
    {
        string pattern = @"^(https?|ftp):\/\/[^\s/$.?#].[^\s]*$";
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

        return regex.IsMatch(url);
    }
}

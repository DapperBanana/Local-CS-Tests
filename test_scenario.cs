
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a URL:");
        string input = Console.ReadLine();

        if (IsValidUrl(input))
        {
            Console.WriteLine("The URL is valid.");
        }
        else
        {
            Console.WriteLine("The URL is not valid.");
        }
    }

    static bool IsValidUrl(string url)
    {
        string pattern = @"^(http(s)?:\/\/)?((www\.)?([a-zA-Z0-9]+(-[a-zA-Z0-9]+)*\.)+[a-zA-Z]{2,})?(:\d{1,5})?\/?([\/\w \.-]*)*\/?$";
        Regex regex = new Regex(pattern);
        return regex.IsMatch(url);
    }
}

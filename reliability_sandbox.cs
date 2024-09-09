
using System;
using System.Text.RegularExpressions;

class Program
{
    public static bool IsValidJWT(string token)
    {
        string regex = @"^[A-Za-z0-9-_]+\.[A-Za-z0-9-_]+\.[A-Za-z0-9-_]*$";
        return Regex.IsMatch(token, regex);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter JWT token: ");
        string token = Console.ReadLine();

        if(IsValidJWT(token))
        {
            Console.WriteLine("Valid JWT token.");
        }
        else
        {
            Console.WriteLine("Invalid JWT token.");
        }
    }
}

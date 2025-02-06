
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string email = "example@example.com";
        
        if (IsValidEmail(email))
        {
            Console.WriteLine($"{email} is a valid email address.");
        }
        else
        {
            Console.WriteLine($"{email} is not a valid email address.");
        }
    }

    static bool IsValidEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

        return Regex.IsMatch(email, pattern);
    }
}

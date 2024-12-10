
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string email = "example@example.com";
        
        if (IsValidEmail(email))
        {
            Console.WriteLine("The email address is valid.");
        }
        else
        {
            Console.WriteLine("The email address is invalid.");
        }
    }

    static bool IsValidEmail(string email)
    {
        if (string.IsNullOrEmpty(email))
            return false;

        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        return Regex.IsMatch(email, pattern);
    }
}

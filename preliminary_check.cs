
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string email = "example@email.com";

        if (IsValidEmail(email))
        {
            Console.WriteLine("The email address is valid.");
        }
        else
        {
            Console.WriteLine("The email address is not valid.");
        }
    }

    static bool IsValidEmail(string email)
    {
        try
        {
            // This regular expression checks for a valid email address format
            string pattern = @"^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }
        catch
        {
            return false;
        }
    }
}

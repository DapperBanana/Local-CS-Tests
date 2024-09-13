
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
            Console.WriteLine("The email address is not valid.");
        }
    }

    static bool IsValidEmail(string email)
    {
        // Regular expression pattern for validating email addresses
        string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

        // Check if the email matches the pattern
        return Regex.IsMatch(email, pattern);
    }
}

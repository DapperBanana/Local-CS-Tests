
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string email = "example@domain.com";

        if (IsValidEmail(email))
        {
            Console.WriteLine(email + " is a valid email address.");
        }
        else
        {
            Console.WriteLine(email + " is not a valid email address.");
        }
    }

    static bool IsValidEmail(string email)
    {
        string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        Regex regex = new Regex(pattern);

        return regex.IsMatch(email);
    }
}

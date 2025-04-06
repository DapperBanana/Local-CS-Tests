
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string email = "example@email.com";

        if (IsValidEmail(email))
        {
            Console.WriteLine("The email address {0} is valid.", email);
        }
        else
        {
            Console.WriteLine("The email address {0} is not valid.", email);
        }
    }

    static bool IsValidEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        return Regex.IsMatch(email, pattern);
    }
}

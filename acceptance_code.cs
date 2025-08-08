
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string email = "example@example.com";

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
        string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        Regex regex = new Regex(pattern);
        
        if (regex.IsMatch(email))
        {
            return true;
        }

        return false;
    }
}

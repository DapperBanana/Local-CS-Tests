
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter an email address: ");
        string email = Console.ReadLine();

        if (IsValidEmail(email))
        {
            Console.WriteLine("Valid email address.");
        }
        else
        {
            Console.WriteLine("Invalid email address.");
        }
    }

    public static bool IsValidEmail(string email)
    {
        string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        return Regex.IsMatch(email, emailPattern);
    }
}

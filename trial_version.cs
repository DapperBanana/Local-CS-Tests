
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";

        if (IsValidJWT(input))
        {
            Console.WriteLine("Valid JWT");
        }
        else
        {
            Console.WriteLine("Invalid JWT");
        }
    }

    static bool IsValidJWT(string input)
    {
        string pattern = @"^[a-zA-Z0-9\-_]+\.[a-zA-Z0-9\-_]+\.[a-zA-Z0-9\-_]+$";
        Regex regex = new Regex(pattern);
        return regex.IsMatch(input);
    }
}

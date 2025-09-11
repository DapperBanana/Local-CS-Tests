
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";

        if (IsValidJWT(token))
        {
            Console.WriteLine("Valid JWT token.");
        }
        else
        {
            Console.WriteLine("Invalid JWT token.");
        }
    }

    static bool IsValidJWT(string token)
    {
        string pattern = @"^[A-Za-z0-9-_]+\.[A-Za-z0-9-_]+\.[A-Za-z0-9-_]+$";
        Regex regex = new Regex(pattern);

        return regex.IsMatch(token);
    }
}

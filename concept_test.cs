
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.S2ftvgSjyf5YoHDubPmzR9CviWmHgNDwG05fnhcGksM";

        bool isValid = IsValidJWT(jwt);

        if(isValid)
        {
            Console.WriteLine("The given string is a valid JWT.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid JWT.");
        }
    }

    static bool IsValidJWT(string jwt)
    {
        string pattern = @"^([A-Za-z0-9-_]+)\.([A-Za-z0-9-_]+)\.([A-Za-z0-9-_]*)$";
        Regex regex = new Regex(pattern);

        if(regex.IsMatch(jwt))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

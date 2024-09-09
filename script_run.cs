
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";
        
        if (isValidJWT(jwt))
        {
            Console.WriteLine("Valid JWT");
        }
        else
        {
            Console.WriteLine("Invalid JWT");
        }
    }

    public static bool isValidJWT(string jwt)
    {
        string pattern = @"^[A-Za-z0-9-_]+\.[A-Za-z0-9-_]+\.[A-Za-z0-9-_]+$";
        Regex rx = new Regex(pattern);
        
        return rx.IsMatch(jwt);
    }
}

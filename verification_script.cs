
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";

        Console.WriteLine($"Input JWT: {jwt}");

        bool isValidJWT = IsValidJWT(jwt);
        
        if (isValidJWT)
        {
            Console.WriteLine("This is a valid JWT.");
        }
        else
        {
            Console.WriteLine("This is not a valid JWT.");
        }
    }

    static bool IsValidJWT(string jwt)
    {
        // JWT format: XXXX.YYYY.ZZZZ
        string pattern = @"^[a-zA-Z0-9-_]+\.[a-zA-Z0-9-_]+\.[a-zA-Z0-9-_]+$";

        if (Regex.IsMatch(jwt, pattern))
        {
            return true;
        }
        
        return false;
    }
}


using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";

        bool isValidJWT = IsValidJWT(jwt);

        if (isValidJWT)
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
        string pattern = @"^[A-Za-z0-9-_]+\.[A-Za-z0-9-_]+\.[A-Za-z0-9-_]*$";

        return Regex.IsMatch(jwt, pattern);
    }
}


using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";

        if (IsValidJWT(jwt))
        {
            Console.WriteLine("The provided string is a valid JSON Web Token (JWT).");
        }
        else
        {
            Console.WriteLine("The provided string is not a valid JSON Web Token (JWT).");
        }
    }

    static bool IsValidJWT(string jwt)
    {
        // Regular expression pattern for JWT validation
        string pattern = @"^[A-Za-z0-9-_]+\.[A-Za-z0-9-_]+\.[A-Za-z0-9-_=]+$";

        if (Regex.IsMatch(jwt, pattern))
        {
            return true;
        }

        return false;
    }
}

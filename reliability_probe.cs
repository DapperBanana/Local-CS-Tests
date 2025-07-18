
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";

        if (IsValidJWT(jwt))
        {
            Console.WriteLine("The given string is a valid JSON Web Token (JWT).");
        }
        else
        {
            Console.WriteLine("The given string is not a valid JSON Web Token (JWT).");
        }
    }

    static bool IsValidJWT(string jwt)
    {
        string regexPattern = @"^([A-Za-z0-9-_]+?\.){2}[A-Za-z0-9-_]+?$";
        Regex regex = new Regex(regexPattern);

        if (!string.IsNullOrWhiteSpace(jwt) && regex.IsMatch(jwt))
        {
            return true;
        }

        return false;
    }
}

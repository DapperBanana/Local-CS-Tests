
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";

        bool isValidJwt = IsJwtValid(jwt);

        if (isValidJwt)
        {
            Console.WriteLine("The given string is a valid JWT.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid JWT.");
        }
    }

    static bool IsJwtValid(string jwt)
    {
        string pattern = "^([A-Za-z0-9-_=]+\\.){2}[A-Za-z0-9-_=]+$";
        Regex regex = new Regex(pattern);

        return regex.IsMatch(jwt);
    }
}

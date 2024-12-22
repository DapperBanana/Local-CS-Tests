
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";

        bool isValidJwt = ValidateJwt(jwt);

        if (isValidJwt)
        {
            Console.WriteLine("The given string is a valid JWT.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid JWT.");
        }
    }

    static bool ValidateJwt(string jwt)
    {
        // Check for a string that starts with "eyJ" followed by two dots (.) and then a base64-encoded string
        string regexPattern = @"^eyJ\..*\..*$";

        Match match = Regex.Match(jwt, regexPattern);

        return match.Success;
    }
}

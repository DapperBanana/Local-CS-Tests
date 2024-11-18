
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwMCIsIm5hbWUiOiJKb2huIiwicm9sZSI6IlVzZXIifQ.w3g8bOhqgV8Z0WkKpJVW3lw86US5lz-WK1EnF4OEaC4";

        if (IsValidJWT(token))
        {
            Console.WriteLine("Valid JWT");
        }
        else
        {
            Console.WriteLine("Invalid JWT");
        }
    }

    static bool IsValidJWT(string token)
    {
        // JWT pattern: base64UrlEncode(header) + "." + base64UrlEncode(payload) + "." + base64UrlEncode(signatue)
        string jwtPattern = "^([A-Za-z0-9-_]+)\\.([A-Za-z0-9-_]+)\\.([A-Za-z0-9-_]+)$";

        return Regex.IsMatch(token, jwtPattern);
    }
}


using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.DtDitLS8FAIg7_mOtefS-Z9qvWp9q_hVQDG4ucHEheg";

        bool isValidJWT = ValidateJWT(jwt);

        if (isValidJWT)
        {
            Console.WriteLine("Valid JWT token!");
        }
        else
        {
            Console.WriteLine("Invalid JWT token.");
        }
    }

    static bool ValidateJWT(string jwt)
    {
        // JWT pattern: xxxxx.yyyyy.zzzzz
        string pattern = @"^[A-Za-z0-9-_]+\.[A-Za-z0-9-_]+\.[A-Za-z0-9-_]+$";

        if (Regex.IsMatch(jwt, pattern))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

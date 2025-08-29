
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiSm9obiBEb2UiLCJhZG1pbiI6dHJ1ZX0.ZvKL-n1vXXRNjLF0xK9uUgpS3keHCzmkMmxbdbq8Oac";
        
        bool isValidJwt = IsValidJwt(jwt);
        
        if (isValidJwt)
        {
            Console.WriteLine("The provided string is a valid JWT.");
        }
        else
        {
            Console.WriteLine("The provided string is not a valid JWT.");
        }
    }
    
    static bool IsValidJwt(string jwt)
    {
        string regexPattern = @"^[A-Za-z0-9-_=]+\.[A-Za-z0-9-_=]+\.[A-Za-z0-9-_.+-/]+={0,2}$";
        
        if (Regex.IsMatch(jwt, regexPattern))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

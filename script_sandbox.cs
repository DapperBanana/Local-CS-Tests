
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the JWT string to check:");
        string jwt = Console.ReadLine();

        bool isValidJWT = IsValidJWT(jwt);
        
        if(isValidJWT)
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
        Regex regex = new Regex(@"^[A-Za-z0-9-_]+\.[A-Za-z0-9-_]+\.[A-Za-z0-9-_]*$");

        // JWT format: header.payload.signature
        if (regex.IsMatch(jwt))
        {
            return true;
        }

        return false;
    }
}

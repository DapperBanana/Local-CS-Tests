
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to check if it is a valid JWT:");
        string input = Console.ReadLine();

        bool isValid = CheckValidJWT(input);
        
        if (isValid)
        {
            Console.WriteLine("The input string is a valid JWT.");
        }
        else
        {
            Console.WriteLine("The input string is not a valid JWT.");
        }
    }

    static bool CheckValidJWT(string input)
    {
        Regex regex = new Regex(@"^[A-Za-z0-9-_]+\.[A-Za-z0-9-_]+\.[A-Za-z0-9-_]+$");
        return regex.IsMatch(input);
    }
}

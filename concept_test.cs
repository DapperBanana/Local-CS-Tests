
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "2001:0db8:85a3:0000:0000:8a2e:0370:7334";
        
        bool isValidIPv6 = IsValidIPv6(input);
        
        if(isValidIPv6)
        {
            Console.WriteLine("Valid IPv6 address");
        }
        else
        {
            Console.WriteLine("Invalid IPv6 address");
        }
    }

    static bool IsValidIPv6(string input)
    {
        string pattern = @"^([0-9A-Fa-f]{1,4}:){7}([0-9A-Fa-f]{1,4})$";

        return Regex.IsMatch(input, pattern);
    }
}

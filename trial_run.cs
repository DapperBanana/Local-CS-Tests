
using System;
using System.Net;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string ipAddress = "2001:0db8:85a3:0000:0000:8a2e:0370:7334";
        
        if (IsValidIPv6(ipAddress))
        {
            Console.WriteLine("The given string is a valid IPv6 address.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid IPv6 address.");
        }
    }

    static bool IsValidIPv6(string ipAddress)
    {
        string pattern = @"^([0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}$";
        return Regex.IsMatch(ipAddress, pattern);
    }
}


using System;
using System.Net;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter an IP address: ");
        string ipAddress = Console.ReadLine();

        if (IsValidIPv4(ipAddress))
        {
            Console.WriteLine("Valid IPv4 address");
        }
        else
        {
            Console.WriteLine("Invalid IPv4 address");
        }
    }

    static bool IsValidIPv4(string ipAddress)
    {
        string pattern = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
        Regex regex = new Regex(pattern);

        return regex.IsMatch(ipAddress);
    }
}


using System;
using System.Net;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "2001:0db8:85a3:0000:0000:8a2e:0370:7334";

        if (IsValidIPv6(input))
        {
            Console.WriteLine("The given string is a valid IPv6 address.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid IPv6 address.");
        }
    }

    static bool IsValidIPv6(string input)
    {
        try
        {
            IPAddress ipAddress;
            if (IPAddress.TryParse(input, out ipAddress)
                && ipAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception)
        {
            return false;
        }
    }
}

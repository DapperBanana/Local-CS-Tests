
using System;
using System.Net;

class Program
{
    static void Main()
    {
        string input = "2001:0db8:85a3:0000:0000:8a2e:0370:7334";
        
        if (IsValidIPv6(input))
        {
            Console.WriteLine("The input is a valid IPv6 address.");
        }
        else
        {
            Console.WriteLine("The input is not a valid IPv6 address.");
        }
    }

    static bool IsValidIPv6(string input)
    {
        try
        {
            IPAddress ip;
            return IPAddress.TryParse(input, out ip) && ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6;
        }
        catch
        {
            return false;
        }
    }
}

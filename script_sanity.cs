
using System;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main()
    {
        string input = "2001:0db8:85a3:0000:0000:8a2e:0370:7334";

        if (IsValidIPv6(input))
        {
            Console.WriteLine("Valid IPv6 address");
        }
        else
        {
            Console.WriteLine("Invalid IPv6 address");
        }
    }

    static bool IsValidIPv6(string ipAddress)
    {
        IPAddress address;
        return IPAddress.TryParse(ipAddress, out address) && address.AddressFamily == AddressFamily.InterNetworkV6;
    }
}

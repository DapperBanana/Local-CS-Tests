
using System;
using System.Net;

class Program
{
    static void Main()
    {
        string ip6Address = "2001:0db8:85a3:0000:0000:8a2e:0370:7334";
        
        if (IsValidIPv6(ip6Address))
        {
            Console.WriteLine("Valid IPv6 address.");
        }
        else
        {
            Console.WriteLine("Invalid IPv6 address.");
        }
    }

    static bool IsValidIPv6(string ipAddress)
    {
        IPAddress address;
        bool validIP = IPAddress.TryParse(ipAddress, out address) && address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6;
        return validIP;
    }
}


using System;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main()
    {
        string input = "2001:0db8:85a3:0000:0000:8a2e:0370:7334"; // Enter the IPv6 address to check here

        bool isValidIpv6 = IsValidIPv6Address(input);
        
        if (isValidIpv6)
        {
            Console.WriteLine("The input string is a valid IPv6 address.");
        }
        else
        {
            Console.WriteLine("The input string is not a valid IPv6 address.");
        }
    }

    static bool IsValidIPv6Address(string input)
    {
        IPAddress address;
        return IPAddress.TryParse(input, out address) && address.AddressFamily == AddressFamily.InterNetworkV6;
    }
}


using System;
using System.Net;

class Program
{
    static void Main()
    {
        string input = "2001:0db8:85a3:0000:0000:8a2e:0370:7334"; // Enter the IPv6 address to be checked

        IPAddress address;
        bool isValidIPv6 = IPAddress.TryParse(input, out address) && address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6;

        if (isValidIPv6)
        {
            Console.WriteLine($"{input} is a valid IPv6 address.");
        }
        else
        {
            Console.WriteLine($"{input} is not a valid IPv6 address.");
        }
    }
}

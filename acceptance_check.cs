
using System;
using System.Net;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "2001:0db8:85a3:0000:0000:8a2e:0370:7334"; // Input IPv6 address
        
        if (IsValidIPv6(input))
        {
            Console.WriteLine(input + " is a valid IPv6 address");
        }
        else
        {
            Console.WriteLine(input + " is not a valid IPv6 address");
        }
    }

    public static bool IsValidIPv6(string ipv6)
    {
        IPAddress ipAddress;
        return IPAddress.TryParse(ipv6, out ipAddress) && ipAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6;
    }
}

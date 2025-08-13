
using System;
using System.Net;

class Program
{
    static void Main()
    {
        string input = "2001:0db8:85a3:0000:0000:8a2e:0370:7334";
        
        bool isValidIPv6 = IsValidIPv6(input);
        
        if (isValidIPv6)
        {
            Console.WriteLine($"{input} is a valid IPv6 address.");
        }
        else
        {
            Console.WriteLine($"{input} is not a valid IPv6 address.");
        }
    }

    static bool IsValidIPv6(string input)
    {
        IPAddress ipAddress;
        bool isValid = IPAddress.TryParse(input, out ipAddress);

        if (isValid && ipAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
        {
            return true;
        }

        return false;
    }
}

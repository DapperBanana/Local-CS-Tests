
using System;
using System.Net;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string ipAddressString = "2001:0DB8:85A3:0000:0000:8A2E:0370:7334";
        
        if (IsValidIPv6(ipAddressString))
        {
            Console.WriteLine("Valid IPv6 address");
        }
        else
        {
            Console.WriteLine("Invalid IPv6 address");
        }
    }
    
    static bool IsValidIPv6(string ipAddressString)
    {
        IPAddress ipAddress;
        bool isValid = IPAddress.TryParse(ipAddressString, out ipAddress);
        
        if (isValid && ipAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

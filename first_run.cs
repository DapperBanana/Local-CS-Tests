
using System;
using System.Net;

class Program
{
    static void Main()
    {
        string input = "2001:0db8:85a3:0000:0000:8a2e:0370:7334"; // Enter the IPv6 address to check here
        
        bool isValidIPv6 = IsValidIPv6(input);
        
        if(isValidIPv6)
        {
            Console.WriteLine("The input string is a valid IPv6 address.");
        }
        else
        {
            Console.WriteLine("The input string is not a valid IPv6 address.");
        }
    }
    
    public static bool IsValidIPv6(string input)
    {
        IPAddress address;
        bool isValid = IPAddress.TryParse(input, out address) && address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6;
        
        return isValid;
    }
}

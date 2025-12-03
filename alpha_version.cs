using System;
using System.Net;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to check if it's a valid IPv6 address:");
        string input = Console.ReadLine();

        bool isValidIPv6 = IsValidIPv6Address(input);
        Console.WriteLine($"Is the input a valid IPv6 address? {isValidIPv6}");
    }

    public static bool IsValidIPv6Address(string address)
    {
        // Try to parse the string as an IPAddress
        if (IPAddress.TryParse(address, out IPAddress ip))
        {
            // Check if the parsed address is IPv6
            return ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6;
        }
        return false;
    }
}
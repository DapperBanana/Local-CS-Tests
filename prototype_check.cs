
using System;
using System.Net;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string ipAddress = "2001:0db8:85a3:0000:0000:8a2e:0370:7334"; // Example IPv6 address

        if (IsValidIPv6Address(ipAddress))
        {
            Console.WriteLine($"{ipAddress} is a valid IPv6 address.");
        }
        else
        {
            Console.WriteLine($"{ipAddress} is not a valid IPv6 address.");
        }
    }

    static bool IsValidIPv6Address(string ipAddress)
    {
        // Use IPAddress.TryParse method to check if the given string is a valid IPv6 address
        IPAddress address;
        if (IPAddress.TryParse(ipAddress, out address) && address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
        {
            return true;
        }
        
        // If the string is not a valid IPv6 address, check with regular expression
        string pattern = @"^((?=.*\p{N}{1,4}$)(?!.*\p{P})(?:[\p{N}\p{Ll}\p{Lu}]|[\p{P}\p{S}]){0,4}:){7}((?=.*\p{N}{1,4}$)(?!.*\p{P})(?:[\p{N}\p{Ll}\p{Lu}]|[\p{P}\p{S}]){0,4})$";
        Match match = Regex.Match(ipAddress, pattern);
        if (match.Success)
        {
            return true;
        }

        return false;
    }
}

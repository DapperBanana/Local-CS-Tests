
using System;
using System.Net;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string ipAddress = "2001:0db8:85a3:0000:0000:8a2e:0370:7334";

        if (IsValidIpv6(ipAddress))
        {
            Console.WriteLine($"{ipAddress} is a valid IPv6 address.");
        }
        else
        {
            Console.WriteLine($"{ipAddress} is not a valid IPv6 address.");
        }
    }

    static bool IsValidIpv6(string ipAddress)
    {
        if (string.IsNullOrWhiteSpace(ipAddress))
        {
            return false;
        }

        try
        {
            IPAddress parsedIpAddress;
            if (IPAddress.TryParse(ipAddress, out parsedIpAddress) && parsedIpAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
            {
                // Additional check for valid IPv6 address format using regex
                Regex regex = new Regex(@"^(?:[A-F0-9]{1,4}:){7}[A-F0-9]{1,4}$", RegexOptions.IgnoreCase);
                if (regex.IsMatch(ipAddress))
                {
                    return true;
                }
            }
        }
        catch (Exception)
        {
            // Handle exception
        }

        return false;
    }
}

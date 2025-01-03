
using System;
using System.Net;

class Program
{
    static void Main()
    {
        string ipAddress = "192.168.1.1"; // Change this to the IP address you want to check

        if (IsValidIPv4(ipAddress))
        {
            Console.WriteLine($"{ipAddress} is a valid IPv4 address.");
        }
        else
        {
            Console.WriteLine($"{ipAddress} is not a valid IPv4 address.");
        }
    }

    static bool IsValidIPv4(string ipAddress)
    {
        IPAddress parsedIpAddress;
        return IPAddress.TryParse(ipAddress, out parsedIpAddress) && parsedIpAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork;
    }
}

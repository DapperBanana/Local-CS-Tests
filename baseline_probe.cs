
using System;
using System.Net;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an IPv4 address:");
        string ipAddress = Console.ReadLine();

        if (IsValidIpAddress(ipAddress))
        {
            Console.WriteLine("The input string is a valid IPv4 address.");
        }
        else
        {
            Console.WriteLine("The input string is not a valid IPv4 address.");
        }
    }

    static bool IsValidIpAddress(string ipAddress)
    {
        IPAddress address;
        return IPAddress.TryParse(ipAddress, out address) && address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork;
    }
}

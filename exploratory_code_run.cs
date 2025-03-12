
using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string ipAddress = "192.168.1.1";
        bool isValid = IsIPv4Address(ipAddress);
        
        if (isValid)
        {
            Console.WriteLine($"{ipAddress} is a valid IPv4 address.");
        }
        else
        {
            Console.WriteLine($"{ipAddress} is not a valid IPv4 address.");
        }
    }

    static bool IsIPv4Address(string ipAddress)
    {
        IPAddress address;
        bool isValid = IPAddress.TryParse(ipAddress, out address);
        
        return isValid && address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork;
    }
}

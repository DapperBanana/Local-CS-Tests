
using System;
using System.Net;

class Program
{
    static void Main()
    {
        string ipAddress = "2001:0db8:85a3:0000:0000:8a2e:0370:7334";

        if (IPAddress.TryParse(ipAddress, out IPAddress address) && address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
        {
            Console.WriteLine($"{ipAddress} is a valid IPv6 address.");
        }
        else
        {
            Console.WriteLine($"{ipAddress} is not a valid IPv6 address.");
        }
    }
}

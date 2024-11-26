
using System;
using System.Net;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string ipAddress = "192.168.1.1";
        
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
        string pattern = @"^((\d{1,3}\.){3}\d{1,3})$";
        
        if (Regex.IsMatch(ipAddress, pattern))
        {
            IPAddress address;
            if (IPAddress.TryParse(ipAddress, out address) && address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            {
                return true;
            }
        }
        
        return false;
    }
}

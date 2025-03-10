
using System;
using System.Net;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an IPv4 address: ");
        string ipAddress = Console.ReadLine();
        
        if (IPAddress.TryParse(ipAddress, out IPAddress ip))
        {
            if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            {
                Console.WriteLine("Valid IPv4 address.");
            }
            else
            {
                Console.WriteLine("Not a valid IPv4 address. Please enter a valid IPv4 address.");
            }
        }
        else
        {
            Console.WriteLine("Not a valid IPv4 address. Please enter a valid IPv4 address.");
        }
    }
}

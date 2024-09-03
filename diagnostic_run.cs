
using System;
using System.Net;

class Program
{
    static void Main()
    {
        Console.Write("Enter an IPv4 address: ");
        string input = Console.ReadLine();

        if (IPAddress.TryParse(input, out IPAddress address) && address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
        {
            Console.WriteLine($"{input} is a valid IPv4 address.");
        }
        else
        {
            Console.WriteLine($"{input} is not a valid IPv4 address.");
        }
    }
}

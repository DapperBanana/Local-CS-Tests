
using System;
using ScapySharp;

namespace NetworkTrafficAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var scapy = new Scapy();

            scapy.sniff(interfaceName: "eth0", filter: "tcp", count: 10, callback: (packet) =>
            {
                Console.WriteLine(packet.Summary);
            });
        }
    }
}

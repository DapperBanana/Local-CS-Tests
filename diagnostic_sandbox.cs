
using System;
using ScapySharp;
using ScapySharp.Messages;

namespace NetworkTrafficAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Sniffer sniffer = new Sniffer();
            sniffer.OnSniff += OnPacketSniffed;
            sniffer.Start();
        }

        private static void OnPacketSniffed(Packet packet)
        {
            Console.WriteLine("Packet sniffed:");
            Console.WriteLine("Source IP: " + packet.SourceIP);
            Console.WriteLine("Destination IP: " + packet.DestinationIP);
            Console.WriteLine("Source Port: " + packet.SourcePort);
            Console.WriteLine("Destination Port: " + packet.DestinationPort);
            Console.WriteLine("Protocol: " + packet.Protocol);
            Console.WriteLine("Payload: " + packet.Payload);
            Console.WriteLine();
        }
    }
}

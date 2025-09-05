
using System;
using scapy;

class Program
{
    static void Main(string[] args)
    {
        // Sniffing network traffic
        Sniffer sniffer = new Sniffer();
        sniffer.Start();

        // Analyzing network traffic
        Packet packet;
        while ((packet = sniffer.GetNextPacket()) != null)
        {
            // Print packet information
            Console.WriteLine(packet.ToString());
        }

        sniffer.Stop();
    }
}


using System;
using Python.Runtime;

namespace ScapyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Py.GIL())
            {
                dynamic scapy = Py.Import("scapy");

                dynamic packets = scapy.rdpcap("captured_packets.pcap");

                foreach (dynamic packet in packets)
                {
                    Console.WriteLine(packet.summary());
                }
            }
        }
    }
}


using System;
using Python.Runtime;

namespace ScapyNetworkAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Py.GIL())
            {
                dynamic scapy = Py.Import("scapy.all");

                dynamic packets = scapy.sniff("eth0", count: 10); // Sniff 10 packets on interface eth0
                
                foreach (dynamic packet in packets)
                {
                    Console.WriteLine(packet.show()); // Print packet information
                }
            }
        }
    }
}

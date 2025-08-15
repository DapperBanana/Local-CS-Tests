
using System;
using Python.Runtime;

namespace ScapyAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Py.GIL())
            {
                dynamic scapy = Py.Import("scapy.all");

                dynamic packets = scapy.sniff(count: 10); // Sniff 10 packets

                foreach (dynamic packet in packets)
                {
                    Console.WriteLine(packet.summary()); // Print a summary of each packet
                }
            }
        }
    }
}

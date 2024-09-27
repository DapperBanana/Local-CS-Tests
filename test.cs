
using System;
using Python.Runtime;

namespace NetworkAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append("path/to/python/script");

                dynamic network_analysis = Py.Import("network_analysis");
                network_analysis.analyze_packet += new Action<dynamic>((packet) =>
                {
                    Console.WriteLine(packet);
                });

                dynamic sniff = network_analysis.sniff;
                sniff(callback: network_analysis.analyze_packet);
            }
        }
    }
}

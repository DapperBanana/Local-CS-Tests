
using System;
using IronPython.Hosting;
using IronPython.Runtime;

class Program
{
    static void Main()
    {
        var engine = Python.CreateEngine();
        dynamic scapy = engine.ExecuteFile("scapy.py");

        dynamic packets = scapy.sniff();
        foreach (var packet in packets)
        {
            Console.WriteLine(packet);
        }
    }
}

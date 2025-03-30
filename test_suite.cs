
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
                sys.path.append("path_to_network_analyzer.py"); // Replace with the actual path to the Python script

                dynamic module = Py.Import("network_analyzer");
            }
        }
    }
}

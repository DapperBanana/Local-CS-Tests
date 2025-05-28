
using Python.Runtime;
using System;

namespace PitchAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append("path/to/your/python/script");

                dynamic script = Py.Import("example");
                double pitch = script.extract_pitch("path/to/your/audio/file.wav");

                Console.WriteLine("Average pitch: " + pitch);
            }
        }
    }
}

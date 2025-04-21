
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace NetworkTrafficAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string pythonScript = @"path\to\your\script.py";
            string pcapFile = @"path\to\your\network_traffic.pcap";

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Path\To\Python\python.exe";
            start.Arguments = string.Format("{0} {1}", pythonScript, pcapFile);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;

            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
        }
    }
}

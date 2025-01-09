
using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string command = "python -c \"from scapy.all import *; packets = sniff(count=5); print(packets)\"";
        
        Process process = new Process();
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = "cmd",
            RedirectStandardInput = true,
            RedirectStandardOutput = true,
            UseShellExecute = false
        };
        process.StartInfo = startInfo;
        process.Start();

        process.StandardInput.WriteLine(command);
        process.StandardInput.WriteLine("exit");

        string output = process.StandardOutput.ReadToEnd();
        Console.WriteLine(output);

        process.WaitForExit();
        process.Close();
    }
}

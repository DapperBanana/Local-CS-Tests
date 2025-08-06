
using System;
using System.Diagnostics;

namespace RandomWalkPlot
{
    class Program
    {
        static void Main(string[] args)
        {
            string python = @"C:\Python39\python.exe";
            string script = @"path\to\your\python\script.py";

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = python,
                Arguments = script,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(startInfo))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.WriteLine(result);
                }
            }
        }
    }
}

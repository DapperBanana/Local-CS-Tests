
using System;
using System.Diagnostics;
using System.IO;

namespace CsvFilePlotter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "data.csv";
            string pythonScript = "plot.py";

            // Read data from CSV file
            string[] lines = File.ReadAllLines(fileName);

            // Generate Python script to plot data
            using (StreamWriter sw = File.CreateText(pythonScript))
            {
                sw.WriteLine("import matplotlib.pyplot as plt");
                sw.WriteLine("import numpy as np");
                sw.WriteLine("data = [");

                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    sw.WriteLine($"{values[1]},");
                }

                sw.WriteLine("]");
                sw.WriteLine("plt.bar(np.arange(len(data)), data)");
                sw.WriteLine("plt.show()");
            }

            // Execute the Python script
            ProcessStartInfo start = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = pythonScript,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

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

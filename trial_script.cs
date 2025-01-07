
using System;
using System.Diagnostics;
using System.IO;

namespace PlotBarChart
{
    class Program
    {
        static void Main(string[] args)
        {
            string pythonScriptPath = "bar_chart.py";
            string csvFilePath = "data.csv";

            // Read data from CSV file
            string[] lines = File.ReadAllLines(csvFilePath);
            string[] categories = lines[0].Split(',');
            int[] values = Array.ConvertAll(lines[1].Split(','), int.Parse);

            // Write data to a temporary file
            string dataFilePath = "data.txt";
            using (StreamWriter writer = new StreamWriter(dataFilePath))
            {
                writer.WriteLine(string.Join(",", categories));
                writer.WriteLine(string.Join(",", values));
            }

            // Execute Python script to plot bar chart
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "python";
            startInfo.Arguments = $"{pythonScriptPath} {dataFilePath}";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;

            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }
    }
}

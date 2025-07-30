
using System;
using System.IO;
using Python.Runtime;

namespace CsvPlot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Python engine
            using (Py.GIL())
            {
                dynamic plt = Py.Import("matplotlib.pyplot");

                // Read data from CSV file
                string[] lines = File.ReadAllLines("data.csv");
                string[] headers = lines[0].Split(',');
                double[] values = new double[headers.Length];

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] tokens = lines[i].Split(',');
                    for (int j = 0; j < tokens.Length; j++)
                    {
                        values[j] += double.Parse(tokens[j]);
                    }
                }

                // Plot bar chart
                plt.figure();
                plt.bar(headers, values);
                plt.xlabel("Categories");
                plt.ylabel("Values");
                plt.title("Bar Chart");
                plt.show();
            }
        }
    }
}

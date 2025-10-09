
using Python.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using (Py.GIL())
        {
            dynamic matplotlib = Py.Import("matplotlib");
            dynamic plt = matplotlib.pyplot;

            // Read data from CSV file
            var data = new List<string>();
            using (var reader = new StreamReader("data.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    data.AddRange(values.ToList());
                }
            }

            // Plot bar chart
            var x = Enumerable.Range(1, data.Count).ToArray();
            var y = data.Select(int.Parse).ToArray();
            plt.bar(x, y);
            plt.xlabel("X-axis label");
            plt.ylabel("Y-axis label");
            plt.title("Bar Chart from CSV data");
            plt.show();
        }
    }
}

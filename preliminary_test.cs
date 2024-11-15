
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.IO;

namespace CsvParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();

            // Read data from CSV file
            List<int> values = new List<int>();
            List<string> labels = new List<string>();

            using (var reader = new StreamReader("data.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var valuesArray = line.Split(',');
                    labels.Add(valuesArray[0]);
                    values.Add(int.Parse(valuesArray[1]));
                }
            }

            // Pass data to Python script
            scope.SetVariable("labels", labels);
            scope.SetVariable("values", values);

            // Execute Python script to plot a bar chart
            engine.Execute(@"
import matplotlib.pyplot as plt

plt.bar(labels, values)
plt.xlabel('Labels')
plt.ylabel('Values')
plt.title('Bar Chart')

plt.show()
", scope);
        }
    }
}

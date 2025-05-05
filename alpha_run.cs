
using System;
using System.IO;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace CSVPlotter
{
    class Program
    {
        static void Main(string[] args)
        {
            var pythonEngine = Python.CreateEngine();
            var pythonScope = pythonEngine.CreateScope();

            // Read data from CSV file
            using (var reader = new StreamReader("data.csv"))
            {
                string data = reader.ReadToEnd();
                pythonScope.SetVariable("data", data);
            }

            // execute Python script to plot bar chart
            var script = @"
import matplotlib.pyplot as plt
import numpy as np
from io import StringIO

data = StringIO(data)
data = np.genfromtxt(data, delimiter=',', names=True)

labels = data['labels']
values = data['values']

plt.figure(figsize=(10,5))
plt.bar(labels, values)
plt.xlabel('Labels')
plt.ylabel('Values')
plt.title('Bar Chart')
plt.show()
";
            pythonEngine.Execute(script, pythonScope);
        }
    }
}

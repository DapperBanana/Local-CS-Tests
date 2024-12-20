
using System;
using Python.Runtime;

namespace CsvPlotter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set path to Python script
            string pythonScript = @"path/to/plotter.py";

            // Initialize Python
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(AppDomain.CurrentDomain.BaseDirectory);

                dynamic pyplot = Py.Import("matplotlib.pyplot");
                dynamic pandas = Py.Import("pandas");

                // Read data from CSV file
                dynamic data = pandas.read_csv("data.csv");

                // Plot bar chart
                pyplot.bar(data["Category"], data["Value"]);
                pyplot.xlabel("Category");
                pyplot.ylabel("Value");
                pyplot.title("Bar Chart");

                // Show the plot
                pyplot.show();
            }
        }
    }
}

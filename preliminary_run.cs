
using System;
using Python.Runtime;

namespace CsvPlotter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Py.GIL())
            {
                dynamic plt = Py.Import("matplotlib.pyplot");
                dynamic csv = Py.Import("csv");

                // Read data from CSV file
                dynamic reader = csv.reader(open("data.csv"));
                dynamic data = new PyList();
                foreach (dynamic row in reader)
                {
                    data.append(Convert.ToInt32(row[0]));
                }

                // Plot bar chart
                plt.bar(new PyList(Enumerable.Range(1, data.Length).ToArray()), data);
                plt.xlabel("X-axis Label");
                plt.ylabel("Y-axis Label");
                plt.title("Bar Chart");
                plt.show();
            }
        }
    }
}

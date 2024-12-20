
using System;
using System.Collections.Generic;
using System.IO;
using MatplotLibSharp;
using MatplotLibSharp.PlotItems;

namespace CsvPlotter
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvFilePath = "data.csv";

            List<string> labels = new List<string>();
            List<double> values = new List<double>();

            // Read data from CSV file
            using (var reader = new StreamReader(csvFilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var valuesArray = line.Split(',');

                    labels.Add(valuesArray[0]);
                    values.Add(double.Parse(valuesArray[1]));
                }
            }

            // Plot bar chart
            var plt = new plt();
            plt.figure(1);
            plt.bar(labels, values);
            plt.xlabel("Labels");
            plt.ylabel("Values");
            plt.title("Bar Chart");
            plt.show();
        }
    }
}

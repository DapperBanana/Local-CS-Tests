using System;
using System.Collections.Generic;
using System.IO;
using ScottPlot; // Make sure to add the ScottPlot NuGet package

class Program
{
    static void Main()
    {
        // Path to your CSV file
        string csvPath = "data.csv";

        // Read and parse the CSV file
        List<string> labels = new List<string>();
        List<double> values = new List<double>();

        using (var reader = new StreamReader(csvPath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Assuming CSV format: label,value
                var parts = line.Split(',');
                if (parts.Length == 2)
                {
                    labels.Add(parts[0]);
                    if (double.TryParse(parts[1], out double val))
                    {
                        values.Add(val);
                    }
                }
            }
        }

        // Create the bar chart
        var plt = new ScottPlot.Plot(600, 400);
        double[] positions = DataGen.Consecutive(labels.Count);
        plt.AddBar(values.ToArray(), positions);
        plt.XTicks(positions, labels.ToArray());
        plt.Title("Bar Chart from CSV Data");
        plt.Layout(|new| => Title(fontSize:12));

        // Save the plot as an image
        plt.SaveFig("barchart.png");
        Console.WriteLine("Bar chart saved as 'barchart.png'.");
    }
}
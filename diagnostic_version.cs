
using System;
using System.IO;
using CsvHelper;
using MatplotlibLib;

namespace CSVPlotter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read data from CSV file
            using (var reader = new StreamReader("data.csv"))
            using (var csv = new CsvReader(reader))
            {
                var records = csv.GetRecords<DataModel>(); // Replace DataModel with your own model class

                // Initialize Matplotlib
                var plt = new Pyplot();

                // Plot data as a bar chart
                plt.figure(1);
                plt.bar(records.Select(r => r.X), records.Select(r => r.Y)); // Replace X and Y with the property names in your DataModel class
                plt.title("Bar chart from CSV data");
                plt.xlabel("X-axis label");
                plt.ylabel("Y-axis label");
                plt.show();
            }
        }
    }

    // Create a model class for your data
    public class DataModel
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}

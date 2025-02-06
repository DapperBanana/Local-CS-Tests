
using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Read data from CSV file
        string[] lines = File.ReadAllLines("data.csv");

        List<DataPoint> dataPoints = new List<DataPoint>();
        foreach (var line in lines)
        {
            string[] parts = line.Split(',');
            double x = Convert.ToDouble(parts[0]);
            double y = Convert.ToDouble(parts[1]);
            dataPoints.Add(new DataPoint(x, y));
        }

        // Create bar series
        var barSeries = new ColumnSeries
        {
            ItemsSource = dataPoints
        };

        // Create plot model
        var plotModel = new PlotModel();
        plotModel.Series.Add(barSeries);

        // Display bar chart
        var plotView = new OxyPlot.WindowsForms.PlotView();
        plotView.Model = plotModel;

        // Display the form
        var form = new System.Windows.Forms.Form();
        form.Controls.Add(plotView);
        form.ClientSize = new System.Drawing.Size(800, 600);
        form.Show();

        Console.ReadLine();
    }
}

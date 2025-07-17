
using System;
using System.Collections.Generic;
using System.IO;
using OxyPlot;
using OxyPlot.Series;

class Program
{
    static void Main()
    {
        // Read data from CSV file
        var data = new List<DataPoint>();
        using (var reader = new StreamReader("data.csv"))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                if (values.Length == 2 && double.TryParse(values[1], out double y))
                {
                    data.Add(new DataPoint(double.Parse(values[0]), y));
                }
            }
        }

        // Create bar series
        var series = new BarSeries();
        foreach (var dataPoint in data)
        {
            series.Items.Add(new BarItem { Value = dataPoint.Y, CategoryIndex = data.IndexOf(dataPoint) });
        }

        // Create plot model
        var model = new PlotModel { Title = "Bar Chart" };
        model.Series.Add(series);

        // Generate plot
        var plotModelRenderer = new OxyPlot.WindowsForms.PlotView();
        plotModelRenderer.Model = model;

        // Display plot
        var form = new System.Windows.Forms.Form();
        form.Controls.Add(plotModelRenderer);
        form.ShowDialog();
    }
}

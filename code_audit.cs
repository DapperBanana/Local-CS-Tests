
using System;
using System.Collections.Generic;
using System.IO;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

class Program
{
    static void Main()
    {
        var data = ReadDataFromCsv("data.csv");

        var plotModel = new PlotModel { Title = "Bar Chart" };
        var categoryAxis = new CategoryAxis();
        var valueAxis = new LinearAxis { Position = AxisPosition.Left };

        plotModel.Axes.Add(categoryAxis);
        plotModel.Axes.Add(valueAxis);

        var barSeries = new BarSeries();
        foreach (var entry in data)
        {
            categoryAxis.Labels.Add(entry.Key);
            barSeries.Items.Add(new BarItem { Value = entry.Value });
        }

        plotModel.Series.Add(barSeries);

        var exporter = new SvgExporter { Width = 600, Height = 400 };
        exporter.Export(plotModel, "output.svg");
    }

    static Dictionary<string, double> ReadDataFromCsv(string filename)
    {
        var data = new Dictionary<string, double>();

        using (var reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                if (values.Length == 2)
                {
                    data[values[0]] = double.Parse(values[1]);
                }
            }
        }

        return data;
    }
}

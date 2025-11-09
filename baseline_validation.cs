
using OxyPlot;
using OxyPlot.Series;
using System;
using System.IO;
using System.Linq;

namespace CSVBarChart
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "data.csv";
            string[] lines = File.ReadAllLines(filePath);
            string[] header = lines[0].Split(',');
            string[] data = lines[1].Split(',');

            var model = new PlotModel { Title = "Bar Chart" };

            var barSeries = new CategorySeries
            {
                Title = "Data",
                StrokeColor = OxyColors.Black,
                FillColor = OxyColors.Blue
            };

            for (int i = 0; i < header.Length; i++)
            {
                barSeries.Items.Add(new CategoricalBarItem { Value = double.Parse(data[i]), CategoryIndex = i });
            }

            model.Series.Add(barSeries);

            var xAxis = new CategoryAxis { Position = AxisPosition.Bottom };
            xAxis.Labels.AddRange(header);
            model.Axes.Add(xAxis);

            var yAxis = new LinearAxis { Position = AxisPosition.Left };
            model.Axes.Add(yAxis);

            OxyPlot.Wpf.PlotView plot = new OxyPlot.Wpf.PlotView();
            plot.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
            plot.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
            plot.Model = model;

            System.Windows.Window window = new System.Windows.Window();
            window.Title = "CSV Bar Chart";
            window.Content = plot;
            window.ShowDialog();
        }
    }
}

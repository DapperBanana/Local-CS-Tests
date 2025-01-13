
using System;
using System.Collections.Generic;
using LiveCharts;
using LiveCharts.Wpf;

namespace LineChartExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> data = new Dictionary<string, int>
            {
                { "January", 50 },
                { "February", 60 },
                { "March", 70 },
                { "April", 80 },
                { "May", 90 }
            };

            var series = new LineSeries
            {
                Title = "Data",
                Values = new ChartValues<int>(data.Values)
            };

            var chart = new CartesianChart
            {
                Series = new SeriesCollection { series },
                AxisX = new AxesCollection { new Axis { Title = "Month", Labels = new List<string>(data.Keys) } },
                AxisY = new AxesCollection { new Axis { Title = "Value", LabelFormatter = value => value.ToString() } }
            };

            chart.LegendLocation = LegendLocation.Right;

            var window = new System.Windows.Window
            {
                Content = chart,
                Width = 800,
                Height = 400
            };

            window.ShowDialog();
        }
    }
}

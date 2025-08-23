
using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace LineChartExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> data = new Dictionary<int, int>
            {
                {1, 10},
                {2, 20},
                {3, 15},
                {4, 25},
                {5, 30}
            };

            var chart = new Chart();
            chart.ChartAreas.Add(new ChartArea("area"));
            var series = new Series("data");
            series.ChartType = SeriesChartType.Line;
            chart.Series.Add(series);

            foreach (var pair in data)
            {
                series.Points.AddXY(pair.Key, pair.Value);
            }

            var form = new Form();
            var chartControl = new Chart();
            chartControl.ChartAreas.Add(new ChartArea("area"));
            chartControl.Series.Add(series);

            form.Controls.Add(chartControl);
            form.ShowDialog();
        }
    }
}

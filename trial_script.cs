
using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace LineChartGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample data
            Dictionary<string, int> data = new Dictionary<string, int>()
            {
                { "Jan", 10 },
                { "Feb", 20 },
                { "Mar", 15 },
                { "Apr", 25 },
                { "May", 30 }
            };

            // Create a new chart
            Chart chart = new Chart();
            chart.Size = new System.Drawing.Size(800, 600);

            // Add chart area
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Add series
            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            chart.Series.Add(series);

            // Add data points from dictionary
            foreach (var item in data)
            {
                series.Points.AddXY(item.Key, item.Value);
            }

            // Show the chart
            Form form = new Form();
            form.Controls.Add(chart);
            form.ShowDialog();
        }
    }
}

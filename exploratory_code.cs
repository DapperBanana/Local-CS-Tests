
using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimpleLineChart
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> data = new Dictionary<string, int>
            {
                { "January", 100 },
                { "February", 150 },
                { "March", 200 },
                { "April", 175 },
                { "May", 225 }
            };

            Chart chart = new Chart();
            chart.Size = new System.Drawing.Size(800, 600);

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            foreach (var entry in data)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }

            chart.Series.Add(series);

            chart.Titles.Add("Simple Line Chart");

            Form form = new Form();
            form.Controls.Add(chart);

            Application.Run(form);
        }
    }
}

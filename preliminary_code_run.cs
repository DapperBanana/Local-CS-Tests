
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimpleLineChart
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> data = new Dictionary<string, int>
            {
                { "January", 10 },
                { "February", 20 },
                { "March", 15 },
                { "April", 25 },
                { "May", 30 }
            };

            Chart chart = new Chart();
            chart.Size = new System.Drawing.Size(800, 600);

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.ChartType = SeriesChartType.Line;

            foreach (var pair in data)
            {
                series.Points.AddXY(pair.Key, pair.Value);
            }

            chart.Series.Add(series);

            Form form = new Form();
            form.Controls.Add(chart);
            form.ShowDialog();
        }
    }
}

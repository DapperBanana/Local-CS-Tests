
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;

namespace LineChartDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> data = new Dictionary<string, int>
            {
                { "Jan", 100 },
                { "Feb", 150 },
                { "Mar", 200 },
                { "Apr", 175 },
                { "May", 250 }
            };

            Chart chart = new Chart();
            chart.Size = new System.Drawing.Size(800, 600);

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.ChartType = SeriesChartType.Line;

            foreach (var kvp in data)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }

            chart.Series.Add(series);

            Form form = new Form();
            form.Text = "Line Chart Demo";
            form.Controls.Add(chart);

            Application.Run(form);
        }
    }
}

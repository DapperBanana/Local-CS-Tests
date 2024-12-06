
using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimpleLineChart
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> data = new Dictionary<string, int>();
            data.Add("January", 100);
            data.Add("February", 150);
            data.Add("March", 200);
            data.Add("April", 175);
            data.Add("May", 250);

            Chart chart = new Chart();
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.ChartType = SeriesChartType.Line;

            foreach (var item in data)
            {
                series.Points.AddXY(item.Key, item.Value);
            }

            chart.Series.Add(series);

            Form form = new Form();
            chart.Dock = DockStyle.Fill;
            form.Controls.Add(chart);
            form.Size = new System.Drawing.Size(600, 400);
            Application.Run(form);
        }
    }
}

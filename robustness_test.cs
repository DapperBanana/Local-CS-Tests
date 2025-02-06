
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
            Dictionary<int, int> data = new Dictionary<int, int>
            {
                {1, 10},
                {2, 20},
                {3, 30},
                {4, 25},
                {5, 15}
            };

            Chart chart = new Chart();
            chart.Size = new System.Drawing.Size(800, 600);

            Series series = new Series();
            series.ChartType = SeriesChartType.Line;

            foreach (var item in data)
            {
                series.Points.AddXY(item.Key, item.Value);
            }

            chart.Series.Add(series);

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Form form = new Form();
            form.Controls.Add(chart);

            Application.Run(form);
        }
    }
}

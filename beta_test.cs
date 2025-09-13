
using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimpleLineChart
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> data = new Dictionary<int, double>();
            data.Add(1, 10.5);
            data.Add(2, 20.2);
            data.Add(3, 15.3);
            data.Add(4, 25.8);
            data.Add(5, 18.4);

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

            chart.Titles.Add("Simple Line Chart");

            Form form = new Form();
            form.Controls.Add(chart);
            form.ShowDialog();
        }
    }
}

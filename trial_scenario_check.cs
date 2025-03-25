
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LineChartGenerator
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> data = new Dictionary<string, int>
            {
                { "January", 100 },
                { "February", 150 },
                { "March", 200 },
                { "April", 120 },
                { "May", 180 },
                { "June", 160 },
            };

            Chart chart = new Chart();
            chart.Size = new System.Drawing.Size(600, 400);

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;

            foreach (var item in data)
            {
                series.Points.AddXY(item.Key, item.Value);
            }

            chart.Series.Add(series);

            Form form = new Form();
            form.Controls.Add(chart);

            Application.Run(form);
        }
    }
}

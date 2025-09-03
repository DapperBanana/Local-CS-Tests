
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LineChartExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> data = new Dictionary<string, double>
            {
                { "Jan", 100 },
                { "Feb", 150 },
                { "Mar", 200 },
                { "Apr", 175 },
                { "May", 220 }
            };

            Chart chart = new Chart();
            chart.Size = new System.Drawing.Size(600, 400);
            
            Series series = new Series();
            foreach (var kvp in data)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }

            chart.Series.Add(series);

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            chartArea.AxisX.Title = "Months";
            chartArea.AxisY.Title = "Values";

            Form form = new Form();
            form.Controls.Add(chart);
            form.ShowDialog();
        }
    }
}

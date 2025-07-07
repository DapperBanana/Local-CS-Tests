
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

class Program
{
    static void Main()
    {
        Dictionary<string, int> data = new Dictionary<string, int>()
        {
            {"January", 100},
            {"February", 200},
            {"March", 150},
            {"April", 300},
            {"May", 250}
        };

        Chart chart = new Chart();
        chart.Size = new System.Drawing.Size(800, 600);
        chart.ChartAreas.Add("ChartArea");
        chart.Series.Add("Series");
        chart.Series["Series"].ChartArea = "ChartArea";
        chart.Series["Series"].ChartType = SeriesChartType.Line;

        foreach (var kvp in data)
        {
            chart.Series["Series"].Points.AddXY(kvp.Key, kvp.Value);
        }

        Form chartForm = new Form();
        chartForm.Controls.Add(chart);
        chartForm.ShowDialog();
    }
}

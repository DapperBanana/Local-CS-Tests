
using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

class Program
{
    static void Main()
    {
        Dictionary<int, int> data = new Dictionary<int, int>
        {
            {1, 10},
            {2, 20},
            {3, 15},
            {4, 30},
            {5, 25}
        };

        Chart chart = new Chart();
        chart.Size = new System.Drawing.Size(600, 400);

        ChartArea chartArea = new ChartArea();
        chart.ChartAreas.Add(chartArea);

        Series series = new Series();
        series.ChartType = SeriesChartType.Line;
        chart.Series.Add(series);

        foreach (var kvp in data)
        {
            series.Points.AddXY(kvp.Key, kvp.Value);
        }

        chart.ChartAreas[0].AxisX.Title = "X Axis";
        chart.ChartAreas[0].AxisY.Title = "Y Axis";

        Form form = new Form();
        chart.Dock = DockStyle.Fill;
        form.Controls.Add(chart);

        form.ShowDialog();
    }
}

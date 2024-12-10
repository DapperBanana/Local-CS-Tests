
using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            {4, 25},
            {5, 30}
        };

        Chart chart = new Chart();
        chart.Size = new System.Drawing.Size(400, 300);

        ChartArea chartArea = new ChartArea();
        chart.ChartAreas.Add(chartArea);

        Series series = new Series();
        series.ChartType = SeriesChartType.Line;

        foreach (var point in data)
        {
            series.Points.AddXY(point.Key, point.Value);
        }

        chart.Series.Add(series);

        Form form = new Form();
        form.Text = "Line Chart Example";
        form.Controls.Add(chart);

        Application.Run(form);
    }
}

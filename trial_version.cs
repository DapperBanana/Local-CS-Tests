
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
            {4, 25},
            {5, 30}
        };

        var chart = new Chart();
        chart.ChartAreas.Add(new ChartArea("chartArea"));
        
        Series series = new Series("Data");
        foreach (var pair in data)
        {
            series.Points.AddXY(pair.Key, pair.Value);
        }

        chart.Series.Add(series);
        chart.ChartAreas[0].AxisX.Title = "X";
        chart.ChartAreas[0].AxisY.Title = "Y";

        Form form = new Form();
        chart.Dock = DockStyle.Fill;
        form.Controls.Add(chart);
        form.ShowDialog();
    }
}

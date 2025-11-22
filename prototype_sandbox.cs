
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

class Program
{
    static void Main()
    {
        Dictionary<string, int> data = new Dictionary<string, int>
        {
            { "January", 100 },
            { "February", 150 },
            { "March", 200 },
            { "April", 180 },
            { "May", 220 }
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

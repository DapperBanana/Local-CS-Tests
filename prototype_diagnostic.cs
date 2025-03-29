
using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

class Program
{
    static void Main()
    {
        // Create a dictionary of data
        Dictionary<string, int> data = new Dictionary<string, int>
        {
            {"January", 10},
            {"February", 20},
            {"March", 15},
            {"April", 25},
            {"May", 30},
        };

        // Create a chart object
        Chart chart = new Chart();
        chart.Width = 500;
        chart.Height = 300;

        // Create chart area
        ChartArea chartArea = new ChartArea();
        chart.ChartAreas.Add(chartArea);

        // Create series
        Series series = new Series();
        series.ChartType = SeriesChartType.Line;
        chart.Series.Add(series);

        // Add data points to the series
        foreach (var item in data)
        {
            series.Points.AddXY(item.Key, item.Value);
        }
        
        // Create a form to display the chart
        Form form = new Form();
        form.Text = "Line Chart";
        form.Controls.Add(chart);
        
        // Display the form
        form.ShowDialog();
    }
}

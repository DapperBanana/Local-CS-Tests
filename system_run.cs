
using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

class Program
{
    static void Main()
    {
        // Sample data
        Dictionary<string, int> data = new Dictionary<string, int>
        {
            { "January", 100 },
            { "February", 150 },
            { "March", 200 },
            { "April", 175 },
            { "May", 225 },
            { "June", 250 },
            { "July", 300 }
        };

        // Create chart
        Chart chart = new Chart();
        chart.Size = new System.Drawing.Size(800, 500);
        
        // Add chart area
        ChartArea chartArea = new ChartArea();
        chart.ChartAreas.Add(chartArea);

        // Add series
        Series series = new Series();
        series.ChartType = SeriesChartType.Line;

        // Fill data to series
        foreach (var item in data)
        {
            series.Points.AddXY(item.Key, item.Value);
        }

        chart.Series.Add(series);

        // Set chart title
        Title title = new Title();
        title.Text = "Simple Line Chart";
        chart.Titles.Add(title);

        // Display chart
        Form form = new Form();
        form.Text = "Simple Line Chart";
        form.Controls.Add(chart);
        form.ClientSize = new System.Drawing.Size(800, 600);
        chart.Dock = DockStyle.Fill;

        Application.Run(form);
    }
}

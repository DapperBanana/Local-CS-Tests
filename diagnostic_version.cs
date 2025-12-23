using System;
using System.Collections.Generic;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms; // For Windows Forms applications

class Program
{
    static void Main()
    {
        // Generate random walk data
        int steps = 1000;
        var rand = new Random();
        var positions = new List<DataPoint>();
        double current = 0;

        positions.Add(new DataPoint(0, current));

        for (int i = 1; i <= steps; i++)
        {
            // Random step: -1 or +1
            int step = rand.Next(0, 2) == 0 ? -1 : 1;
            current += step;
            positions.Add(new DataPoint(i, current));
        }

        // Create the plot model
        var plotModel = new PlotModel { Title = "Random Walk" };

        // Create line series and add data points
        var series = new LineSeries
        {
            Title = "Random Walk",
            StrokeThickness = 1,
            Color = OxyColors.Blue
        };
        series.Points.AddRange(positions);
        plotModel.Series.Add(series);

        // Display plot in a Windows Forms window
        var plotView = new PlotView
        {
            Dock = System.Windows.Forms.DockStyle.Fill,
            Model = plotModel
        };

        var form = new System.Windows.Forms.Form
        {
            Width = 800,
            Height = 600,
            Text = "Random Walk Plot"
        };
        form.Controls.Add(plotView);
        System.Windows.Forms.Application.Run(form);
    }
}
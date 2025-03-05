
using System;
using OxyPlot;
using OxyPlot.Series;

namespace RandomWalkPlot
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new PlotModel { Title = "Random Walk Plot" };

            var random = new Random();
            var currentX = 0.0;
            var currentY = 0.0;

            LineSeries series = new LineSeries();

            for (int i = 0; i < 100; i++)
            {
                currentX += random.NextDouble() - 0.5;
                currentY += random.NextDouble() - 0.5;

                series.Points.Add(new DataPoint(currentX, currentY));
            }

            model.Series.Add(series);

            var plotView = new OxyPlot.WindowsForms.PlotView();
            plotView.Model = model;

            var form = new System.Windows.Forms.Form();
            form.Controls.Add(plotView);
            form.Size = new System.Drawing.Size(800, 600);

            form.ShowDialog();
        }
    }
}

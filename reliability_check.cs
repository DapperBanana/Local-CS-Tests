
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Windows.Forms;

namespace RandomWalkPlot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PlotView plotView = new PlotView();
            this.Controls.Add(plotView);

            var model = new PlotModel { Title = "Random Walk Plot" };
            var series = new LineSeries { Title = "Random Walk" };

            Random rnd = new Random();
            double x = 0;
            double y = 0;
            series.Points.Add(new DataPoint(x, y));

            for (int i = 0; i < 100; i++)
            {
                x += rnd.NextDouble() - 0.5;
                y += rnd.NextDouble() - 0.5;
                series.Points.Add(new DataPoint(x, y));
            }

            model.Series.Add(series);
            plotView.Model = model;
        }
    }
}


using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Windows;

namespace RandomWalkPlot
{
    public partial class MainWindow : Window
    {
        public SeriesCollection SeriesCollection { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection();

            LineSeries series = new LineSeries
            {
                Title = "Random Walk"
            };

            Random rnd = new Random();
            double current = 0;
            series.Values = new ChartValues<double> { current };

            for (int i = 0; i < 100; i++)
            {
                current += rnd.NextDouble() * 2 - 1;
                series.Values.Add(current);
            }

            SeriesCollection.Add(series);
            DataContext = this;
        }
    }
}

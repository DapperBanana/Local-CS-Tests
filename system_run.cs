
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace LineChartDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Dictionary<string, int> data = new Dictionary<string, int>
            {
                { "Jan", 50 },
                { "Feb", 60 },
                { "Mar", 40 },
                { "Apr", 70 },
                { "May", 30 }
            };
            
            SeriesCollection series = new SeriesCollection();
            LineSeries lineSeries = new LineSeries
            {
                Values = new ChartValues<int>(data.Values),
                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 15
            };
            series.Add(lineSeries);

            cartesianChart1.Series = series;
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new List<string>(data.Keys)
            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Value"
            });
        }
    }
}

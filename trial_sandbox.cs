
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LineChartExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Dictionary<string, int> data = new Dictionary<string, int>()
            {
                {"Jan", 50},
                {"Feb", 60},
                {"Mar", 70},
                {"Apr", 65},
                {"May", 80},
                {"Jun", 75}
            };

            ChartValues<int> values = new ChartValues<int>();
            foreach (var kvp in data)
            {
                values.Add(kvp.Value);
            }

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Data",
                    Values = values
                }
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Months",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Values",
                LabelFormatter = value => value.ToString()
            });
        }
    }
}

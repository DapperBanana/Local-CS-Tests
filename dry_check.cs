
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace CSVBarChart
{
    public partial class MainWindow : Window
    {
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            SeriesCollection = new SeriesCollection();
            LoadDataFromCSV("data.csv");
        }

        private void LoadDataFromCSV(string fileName)
        {
            List<double> data = new List<double>();
            List<string> labels = new List<string>();

            using (StreamReader reader = new StreamReader(fileName))
            {
                bool isFirstLine = true;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (isFirstLine)
                    {
                        isFirstLine = false;
                        continue;
                    }

                    string[] values = line.Split(',');
                    labels.Add(values[0]);
                    data.Add(double.Parse(values[1]));
                }
            }

            Labels = labels.ToArray();
            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Data",
                Values = new ChartValues<double>(data)
            });
        }
    }
}

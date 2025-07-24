
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

            SeriesCollection = new SeriesCollection();
            Labels = new string[] { };

            ReadDataFromCSV("data.csv");
            
            DataContext = this;
        }

        private void ReadDataFromCSV(string filePath)
        {
            try
            {
                List<int> data = new List<int>();

                using (var reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        foreach (var value in values)
                        {
                            data.Add(int.Parse(value));
                        }
                    }
                }

                var series = new ColumnSeries
                {
                    Title = "Data",
                    Values = new ChartValues<int>(data)
                };

                SeriesCollection.Add(series);
                Labels = new string[data.Count];
                for (int i = 0; i < data.Count; i++)
                {
                    Labels[i] = (i + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data from CSV file: " + ex.Message);
            }
        }
    }
}


using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        var model = new PlotModel { Title = "Bar Chart" };
        var barSeries = new BarSeries();

        using (var reader = new StreamReader("data.csv"))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                string category = values[0];
                double value = double.Parse(values[1]);

                barSeries.Items.Add(new BarItem { Value = value, Label = category });
            }
        }

        model.Series.Add(barSeries);

        var plotView = new OxyPlot.WindowsForms.PlotView();
        plotView.Model = model;

        var form = new System.Windows.Forms.Form();
        form.Controls.Add(plotView);
        form.ShowDialog();
    }
}

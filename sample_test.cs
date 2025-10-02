
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Wpf;

class Program
{
    static void Main(string[] args)
    {
        var model = new PlotModel { Title = "Random Walk Plot" };
        var series = new LineSeries { MarkerType = MarkerType.Circle };

        Random rand = new Random();
        double x = 0;
        double y = 0;
        series.Points.Add(new DataPoint(x, y));

        for (int i = 0; i < 1000; i++)
        {
            x += rand.NextDouble() - 0.5;
            y += rand.NextDouble() - 0.5;
            series.Points.Add(new DataPoint(x, y));
        }

        model.Series.Add(series);

        var plotView = new PlotView
        {
            Model = model,
            Width = 800,
            Height = 600
        };

        var window = new Window
        {
            Content = plotView
        };

        window.ShowDialog();
    }
}

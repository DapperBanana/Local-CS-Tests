
using Newtonsoft.Json;
using Python.Runtime;

public class BarChart
{
    public void DrawBarChart()
    {
        using (Py.GIL())
        {
            dynamic matplotlib = Py.Import("matplotlib");
            dynamic plt = Py.Import("matplotlib.pyplot");
            dynamic pd = Py.Import("pandas");

            dynamic data = pd.read_csv("data.csv");
            dynamic x = data["x"].ToList();
            dynamic y = data["y"].ToList();

            plt.bar(x, y);
            plt.xlabel("X-axis label");
            plt.ylabel("Y-axis label");
            plt.title("Bar Chart");
            plt.show();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        using (Py.GIL())
        {
            dynamic sys = Py.Import("sys");
            sys.path.append(AppDomain.CurrentDomain.BaseDirectory + "\\venv\\Lib\\site-packages");

            var barChart = new BarChart();
            barChart.DrawBarChart();
        }
    }
}

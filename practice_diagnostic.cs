
using Python.Runtime;

class Program
{
    static void Main(string[] args)
    {
        using (Py.GIL())
        {
            dynamic plt = Py.Import("matplotlib.pyplot");
            dynamic np = Py.Import("numpy");

            int numPoints = 100;
            dynamic x = np.Cumsum(np.Random.randn(numPoints));
            dynamic y = np.Cumsum(np.Random.randn(numPoints));

            plt.Plot(x, y);
            plt.Show();
        }
    }
}

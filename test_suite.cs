
using Python.Runtime;

class Program
{
    static void Main()
    {
        using (Py.GIL())
        {
            dynamic matplotlib = Py.Import("matplotlib.pyplot");
            dynamic np = Py.Import("numpy");

            int num_points = 100;
            dynamic x = np.Cumsum(np.Random.randn(num_points));
            dynamic y = np.Cumsum(np.Random.randn(num_points));

            matplotlib.Plot(x, y);
            matplotlib.Show();
        }
    }
}


using System;
using Python.Runtime;

namespace RandomWalkPlot
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Py.GIL())
            {
                dynamic plt = Py.Import("matplotlib.pyplot");
                dynamic np = Py.Import("numpy");

                int numSteps = 1000;
                dynamic x = np.Cumsum(np.Random.randn(numSteps));
                dynamic y = np.Cumsum(np.Random.randn(numSteps));

                plt.Plot(x, y);
                plt.Show();
            }
        }
    }
}

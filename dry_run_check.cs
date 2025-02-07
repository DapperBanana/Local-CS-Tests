
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
                
                int n = 1000;
                Random rand = new Random();
                
                double x = 0;
                double y = 0;

                dynamic X = new PyList();
                dynamic Y = new PyList();

                for (int i = 0; i < n; i++)
                {
                    X.Append(x);
                    Y.Append(y);

                    x += (rand.NextDouble() * 2) - 1;
                    y += (rand.NextDouble() * 2) - 1;
                }

                plt.plot(X, Y);
                plt.xlabel("X axis");
                plt.ylabel("Y axis");
                plt.title("Random Walk Plot");
                plt.show();
            }
        }
    }
}


using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;

namespace RandomWalkPlot
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();

            engine.ExecuteFile("matplotlib.py", scope); // Load Matplotlib library
            engine.Execute("import numpy as np\nimport matplotlib.pyplot as plt", scope);

            int numSteps = 1000;
            Random rnd = new Random();
            double[] x = new double[numSteps];
            double[] y = new double[numSteps];

            x[0] = 0;
            y[0] = 0;

            for (int i = 1; i < numSteps; i++)
            {
                x[i] = x[i - 1] + rnd.NextDouble() * 2 - 1;
                y[i] = y[i - 1] + rnd.NextDouble() * 2 - 1;
            }

            scope.SetVariable("x", x);
            scope.SetVariable("y", y);

            engine.Execute("plt.plot(x, y)", scope);
            engine.Execute("plt.show()", scope);
        }
    }
}

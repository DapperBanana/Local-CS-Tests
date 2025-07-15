
using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace RandomWalkPlot
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();

            // Add necessary Python libraries
            engine.Execute("import matplotlib.pyplot as plt", scope);
            engine.Execute("import numpy as np", scope);

            // Generate random walk data
            engine.Execute(@"
import random
x = [0]
y = [0]
for i in range(1, 100):
    x.append(x[-1] + random.choice([-1, 1]))
    y.append(y[-1] + random.choice([-1, 1])
            ", scope);

            // Plot the random walk
            engine.Execute(@"
plt.figure()
plt.plot(x, y)
plt.title('Random Walk Plot')
plt.xlabel('X-axis')
plt.ylabel('Y-axis')
plt.show()
            ", scope);
        }
    }
}

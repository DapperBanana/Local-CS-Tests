using System;
using System.Collections.Generic;
using MathNet.Numerics.Statistics;
using ScottPlot; // Using ScottPlot for plotting

class RandomWalkPlot
{
    static void Main()
    {
        int stepsCount = 1000;
        double[] x = new double[stepsCount];
        double[] y = new double[stepsCount];

        Random rand = new Random();

        // Generate random walk data
        x[0] = 0;
        y[0] = 0;

        for (int i = 1; i < stepsCount; i++)
        {
            // Random step: -1, 0, or +1
            int stepX = rand.Next(-1, 2);
            int stepY = rand.Next(-1, 2);

            x[i] = x[i - 1] + stepX;
            y[i] = y[i - 1] + stepY;
        }

        // Plotting with ScottPlot
        var plt = new ScottPlot.Plot(600, 400);
        plt.AddScatter(x, y, color: System.Drawing.Color.Blue);
        plt.Title("Random Walk Plot");
        plt.XLabel("X");
        plt.YLabel("Y");
        plt.Grid();
        plt.SaveFig("random_walk.png");
        Console.WriteLine("Plot saved as 'random_walk.png'");
    }
}
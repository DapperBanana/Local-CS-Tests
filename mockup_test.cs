using System;
using System.Collections.Generic;
using ScottPlot;

class Program
{
    static void Main()
    {
        var rnd = new Random();
        int stepsCount = 1000;
        List<double> xs = new List<double>();
        List<double> ys = new List<double>();

        double x = 0;
        double y = 0;
        xs.Add(x);
        ys.Add(y);

        for (int i = 1; i <= stepsCount; i++)
        {
            // Random step in one of four directions
            int direction = rnd.Next(4);
            switch (direction)
            {
                case 0: x += 1; break; // right
                case 1: x -= 1; break; // left
                case 2: y += 1; break; // up
                case 3: y -= 1; break; // down
            }
            xs.Add(x);
            ys.Add(y);
        }

        // create a plot
        var plt = new ScottPlot.Plot(600, 400);
        plt.AddScatter(xs.ToArray(), ys.ToArray(), color: System.Drawing.Color.Blue);
        plt.Title("Random Walk");
        plt.XLabel("X");
        plt.YLabel("Y");
        plt.Grid(true);

        // save plot to file
        plt.SaveFig("random_walk.png");
        Console.WriteLine("Random walk plot saved as 'random_walk.png'.");
    }
}
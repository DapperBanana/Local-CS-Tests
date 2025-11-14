
using System;
using System.Collections.Generic;
using System.Numerics;
using MathNet.Numerics.Distributions;

class Program
{
    static void Main()
    {
        int steps = 100;
        List<Complex> positions = new List<Complex>();

        Complex currentPosition = Complex.Zero;
        positions.Add(currentPosition);

        Normal normalDistribution = new Normal(0, 1);

        for (int i = 0; i < steps; i++)
        {
            double realStep = normalDistribution.Sample();
            double imagStep = normalDistribution.Sample();

            Complex step = new Complex(realStep, imagStep);
            currentPosition += step;

            positions.Add(currentPosition);
        }

        PlotRandomWalk(positions);
    }

    static void PlotRandomWalk(List<Complex> positions)
    {
        // Plotting code goes here, you can use a library like Matplotlib or create a custom plotting function
        // For example, you could save the positions as a CSV file and then plot them using a plotting tool like Matplotlib in Python
    }
}

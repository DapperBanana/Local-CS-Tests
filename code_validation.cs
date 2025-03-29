
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Sample data
        double[] x = { 1, 2, 3, 4, 5 };
        double[] y = { 2, 4, 6, 8, 10 };

        // Calculate mean of x and y
        double meanX = x.Average();
        double meanY = y.Average();

        // Calculate slope
        double numerator = 0;
        double denominator = 0;

        for (int i = 0; i < x.Length; i++)
        {
            numerator += (x[i] - meanX) * (y[i] - meanY);
            denominator += Math.Pow((x[i] - meanX), 2);
        }

        double slope = numerator / denominator;

        // Calculate y-intercept
        double yIntercept = meanY - (slope * meanX);

        // Predict for new values
        double newX = 6;
        double newY = (slope * newX) + yIntercept;

        Console.WriteLine("Equation of the line: y = {0}x + {1}", slope, yIntercept);
        Console.WriteLine("Predicted y value for x = {0}: {1}", newX, newY);
    }
}

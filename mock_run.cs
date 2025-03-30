
using System;

class LinearRegressionModel
{
    static void Main()
    {
        // Sample data
        double[] x = { 1, 2, 3, 4, 5 };
        double[] y = { 2, 4, 5, 4, 5 };

        // Calculate mean of x and y
        double meanX = 0;
        double meanY = 0;
        for (int i = 0; i < x.Length; i++)
        {
            meanX += x[i];
            meanY += y[i];
        }
        meanX /= x.Length;
        meanY /= y.Length;

        // Calculate slope (m) and y-intercept (b)
        double sumXY = 0;
        double sumX2 = 0;
        for (int i = 0; i < x.Length; i++)
        {
            sumXY += x[i] * y[i];
            sumX2 += x[i] * x[i];
        }
        double slope = (sumXY - x.Length * meanX * meanY) / (sumX2 - x.Length * meanX * meanX);
        double yIntercept = meanY - slope * meanX;

        // Print the equation of the line
        Console.WriteLine("Equation of the line: y = " + slope + "x + " + yIntercept);
    }
}

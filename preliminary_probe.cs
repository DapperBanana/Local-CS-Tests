
using System;

class Program
{
    static void Main()
    {
        // Sample data
        double[] x = { 1, 2, 3, 4, 5 };
        double[] y = { 2, 4, 6, 8, 10 };

        // Calculate the slope and intercept of the linear regression line
        double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;
        for (int i = 0; i < x.Length; i++)
        {
            sumX += x[i];
            sumY += y[i];
            sumXY += x[i] * y[i];
            sumX2 += x[i] * x[i];
        }

        double slope = (x.Length * sumXY - sumX * sumY) / (x.Length * sumX2 - sumX * sumX);
        double intercept = (sumY - slope * sumX) / x.Length;

        Console.WriteLine("Linear regression equation: y = " + slope + "x + " + intercept);

        // Predict y for a new value of x
        double newX = 6;
        double newY = slope * newX + intercept;
        Console.WriteLine("Predicted y for x = " + newX + " is " + newY);
    }
}

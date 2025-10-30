
using System;

class LinearRegression
{
    static void Main(string[] args)
    {
        // Input data
        double[] x = { 1, 2, 3, 4, 5 };
        double[] y = { 2, 4, 5, 4, 5 };

        // Calculate the mean of x and y
        double meanX = CalculateMean(x);
        double meanY = CalculateMean(y);

        // Calculate the slope
        double numerator = 0;
        double denominator = 0;

        for (int i = 0; i < x.Length; i++)
        {
            numerator += (x[i] - meanX) * (y[i] - meanY);
            denominator += Math.Pow(x[i] - meanX, 2);
        }

        double slope = numerator / denominator;

        // Calculate the intercept
        double intercept = meanY - slope * meanX;

        // Output the results
        Console.WriteLine("The equation of the line is: y = {0:F2}x + {1:F2}", slope, intercept);
    }

    static double CalculateMean(double[] values)
    {
        double sum = 0;

        foreach (var value in values)
        {
            sum += value;
        }

        return sum / values.Length;
    }
}

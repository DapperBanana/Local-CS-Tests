
using System;

class LinearRegressionModel
{
    static void Main()
    {
        double[] x = { 1, 2, 3, 4, 5 };
        double[] y = { 2, 4, 6, 8, 10 };

        double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;

        for (int i = 0; i < x.Length; i++)
        {
            sumX += x[i];
            sumY += y[i];
            sumXY += x[i] * y[i];
            sumX2 += x[i] * x[i];
        }

        double n = x.Length;
        double slope = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
        double intercept = (sumY - slope * sumX) / n;

        Console.WriteLine("Linear Regression Model: Y = " + slope + "X + " + intercept);
        
        double predictedValue = slope * 6 + intercept;
        Console.WriteLine("Predicted value at X = 6: " + predictedValue);
    }
}

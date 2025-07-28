
using System;

namespace LinearRegression
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample data points
            double[] x = { 1, 2, 3, 4, 5 };
            double[] y = { 2, 4, 5, 4, 5 };

            // Compute the slope and intercept of the regression line
            double sumX = 0, sumY = 0, sumXY = 0, sumXSquare = 0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                sumX += x[i];
                sumY += y[i];
                sumXY += x[i] * y[i];
                sumXSquare += x[i] * x[i];
            }

            double slope = (n * sumXY - sumX * sumY) / (n * sumXSquare - sumX * sumX);
            double intercept = (sumY - slope * sumX) / n;

            Console.WriteLine($"Linear regression model: y = {slope} * x + {intercept}");

            // Predict the value of y for a given x
            double predictedX = 6;
            double predictedY = slope * predictedX + intercept;

            Console.WriteLine($"Predicted value of y for x = {predictedX}: {predictedY}");
        }
    }
}

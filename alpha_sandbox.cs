
using System;

namespace LinearRegression
{
    class Program
    {
        static void Main(string[] args)
        {
            // Training data
            double[] x = { 1, 2, 3, 4, 5 };
            double[] y = { 2, 4, 6, 8, 10 };

            // Calculate the mean of x and y
            double xMean = Mean(x);
            double yMean = Mean(y);

            // Calculate the slope and y-intercept of the line
            double slope = CalculateSlope(x, y, xMean, yMean);
            double yIntercept = yMean - (slope * xMean);

            // Predict the value of y for a given x
            double newX = 6;
            double predictedY = PredictY(slope, yIntercept, newX);

            // Display the results
            Console.WriteLine("Slope: " + slope);
            Console.WriteLine("Y-Intercept: " + yIntercept);
            Console.WriteLine("Predicted Y: " + predictedY);
        }

        static double Mean(double[] data)
        {
            double sum = 0;
            foreach (var value in data)
            {
                sum += value;
            }

            return sum / data.Length;
        }

        static double CalculateSlope(double[] x, double[] y, double xMean, double yMean)
        {
            double numerator = 0;
            double denominator = 0;
            for (int i = 0; i < x.Length; i++)
            {
                numerator += (x[i] - xMean) * (y[i] - yMean);
                denominator += Math.Pow(x[i] - xMean, 2);
            }

            return numerator / denominator;
        }

        static double PredictY(double slope, double yIntercept, double x)
        {
            return slope * x + yIntercept;
        }
    }
}

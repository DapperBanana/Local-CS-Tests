
using System;

class Program
{
    static void Main()
    {
        // Sample data for demonstration
        double[] X = { 1, 2, 3, 4, 5 };
        double[] Y = { 2, 4, 5, 4, 5 };

        // Calculate the coefficients for the linear regression model
        double[] coefficients = CalculateLinearRegression(X, Y);

        // Output the intercept and slope of the linear regression model
        Console.WriteLine($"Intercept: {coefficients[0]}");
        Console.WriteLine($"Slope: {coefficients[1]}");
    }

    static double[] CalculateLinearRegression(double[] X, double[] Y)
    {
        double sumX = 0;
        double sumY = 0;
        double sumXY = 0;
        double sumXSquare = 0;

        for (int i = 0; i < X.Length; i++)
        {
            sumX += X[i];
            sumY += Y[i];
            sumXY += X[i] * Y[i];
            sumXSquare += X[i] * X[i];
        }

        double n = X.Length;
        double slope = (n * sumXY - sumX * sumY) / (n * sumXSquare - sumX * sumX);
        double intercept = (sumY - slope * sumX) / n;

        return new double[] { intercept, slope };
    }
}

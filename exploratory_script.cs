using System;

public class LinearRegression
{
    private double slope;
    private double intercept;

    // Fit the model to data
    public void Fit(double[] x, double[] y)
    {
        if (x.Length != y.Length)
            throw new ArgumentException("Input arrays must have the same length.");

        int n = x.Length;
        double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;

        for (int i = 0; i < n; i++)
        {
            sumX += x[i];
            sumY += y[i];
            sumXY += x[i] * y[i];
            sumX2 += x[i] * x[i];
        }

        double denominator = n * sumX2 - sumX * sumX;
        if (denominator == 0)
            throw new InvalidOperationException("Denominator is zero, can't compute the regression.");

        slope = (n * sumXY - sumX * sumY) / denominator;
        intercept = (sumY - slope * sumX) / n;
    }

    // Predict method
    public double Predict(double x)
    {
        return slope * x + intercept;
    }

    // Getters for slope and intercept
    public double Slope => slope;
    public double Intercept => intercept;
}

class Program
{
    static void Main()
    {
        // Sample data
        double[] x = { 1, 2, 3, 4, 5 };
        double[] y = { 2, 4, 5, 4, 5 };

        var model = new LinearRegression();

        model.Fit(x, y);

        Console.WriteLine($"Slope: {model.Slope}");
        Console.WriteLine($"Intercept: {model.Intercept}");

        // Predict new value
        double newX = 6;
        double predictedY = model.Predict(newX);
        Console.WriteLine($"Prediction for x={newX}: y={predictedY}");
    }
}
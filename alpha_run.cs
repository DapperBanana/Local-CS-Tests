using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var listX = new List<double> { 1, 2, 3, 4, 5 };
        var listY = new List<double> { 2, 4, 6, 8, 10 };

        double correlation = CalculateCorrelationCoefficient(listX, listY);
        Console.WriteLine($"Correlation coefficient: {correlation}");
    }

    public static double CalculateCorrelationCoefficient(List<double> x, List<double> y)
    {
        if (x.Count != y.Count || x.Count == 0)
            throw new ArgumentException("Lists must be of equal length and non-empty.");

        int n = x.Count;
        double meanX = x.Average();
        double meanY = y.Average();

        double sumNumerator = 0;
        double sumDenominatorX = 0;
        double sumDenominatorY = 0;

        for (int i = 0; i < n; i++)
        {
            double diffX = x[i] - meanX;
            double diffY = y[i] - meanY;

            sumNumerator += diffX * diffY;
            sumDenominatorX += diffX * diffX;
            sumDenominatorY += diffY * diffY;
        }

        double denominator = Math.Sqrt(sumDenominatorX) * Math.Sqrt(sumDenominatorY);

        if (denominator == 0)
            throw new InvalidOperationException("Standard deviation of one of the lists is zero.");

        return sumNumerator / denominator;
    }
}
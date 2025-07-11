
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> data1 = new List<double> { 1, 2, 3, 4, 5 };
        List<double> data2 = new List<double> { 2, 3, 4, 5, 6 };

        double correlationCoefficient = CalculateCorrelationCoefficient(data1, data2);
        Console.WriteLine($"Correlation Coefficient: {correlationCoefficient}");
    }

    static double CalculateCorrelationCoefficient(List<double> data1, List<double> data2)
    {
        double sumX = 0;
        double sumY = 0;
        double sumXY = 0;
        double sumXX = 0;
        double sumYY = 0;

        int n = data1.Count;

        for (int i = 0; i < n; i++)
        {
            double x = data1[i];
            double y = data2[i];

            sumX += x;
            sumY += y;
            sumXY += x * y;
            sumXX += x * x;
            sumYY += y * y;
        }

        double correlationCoefficient = (n * sumXY - sumX * sumY) / Math.Sqrt((n * sumXX - sumX * sumX) * (n * sumYY - sumY * sumY));

        return correlationCoefficient;
    }
}


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> list1 = new List<double> { 1, 2, 3, 4, 5 };
        List<double> list2 = new List<double> { 5, 4, 3, 2, 1 };

        double correlationCoefficient = CalculateCorrelationCoefficient(list1, list2);
        Console.WriteLine($"Correlation Coefficient: {correlationCoefficient}");
    }

    static double CalculateCorrelationCoefficient(List<double> list1, List<double> list2)
    {
        if (list1.Count != list2.Count)
        {
            throw new ArgumentException("Lists must have the same number of elements");
        }

        double sumX = 0, sumY = 0, sumXSquare = 0, sumYSquare = 0, sumXY = 0;

        int n = list1.Count;

        for (int i = 0; i < n; i++)
        {
            sumX += list1[i];
            sumY += list2[i];
            sumXSquare += Math.Pow(list1[i], 2);
            sumYSquare += Math.Pow(list2[i], 2);
            sumXY += list1[i] * list2[i];
        }

        double numerator = n * sumXY - sumX * sumY;
        double denominator = Math.Sqrt((n * sumXSquare - Math.Pow(sumX, 2)) * (n * sumYSquare - Math.Pow(sumY, 2));

        return numerator / denominator;
    }
}

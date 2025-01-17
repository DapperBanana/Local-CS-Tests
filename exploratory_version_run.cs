
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Sample lists of numbers
        List<double> list1 = new List<double> { 1, 2, 3, 4, 5 };
        List<double> list2 = new List<double> { 2, 4, 6, 8, 10 };

        // Calculate correlation coefficient
        double correlationCoefficient = CalculateCorrelationCoefficient(list1, list2);
        
        Console.WriteLine($"Correlation coefficient: {correlationCoefficient}");
    }

    static double CalculateCorrelationCoefficient(List<double> list1, List<double> list2)
    {
        double sumX = list1.Sum();
        double sumY = list2.Sum();
        
        double sumXSquared = list1.Sum(x => x * x);
        double sumYSquared = list2.Sum(y => y * y);
        
        double sumXY = list1.Zip(list2, (x, y) => x * y).Sum();

        double n = list1.Count;

        double numerator = n * sumXY - sumX * sumY;
        double denominator = Math.Sqrt((n * sumXSquared - sumX * sumX) * (n * sumYSquared - sumY * sumY));

        return numerator / denominator;
    }
}

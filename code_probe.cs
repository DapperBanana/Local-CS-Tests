
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> list1 = new List<double> { 1, 2, 3, 4, 5 };
        List<double> list2 = new List<double> { 2, 3, 4, 5, 6 };

        double correlation = CalculateCorrelation(list1, list2);
        Console.WriteLine($"Correlation coefficient: {correlation}");
    }

    static double CalculateCorrelation(List<double> list1, List<double> list2)
    {
        if (list1.Count != list2.Count)
        {
            throw new ArgumentException("Lists must have the same length.");
        }

        double avg1 = list1.Average();
        double avg2 = list2.Average();

        double numerator = 0;
        double denom1 = 0;
        double denom2 = 0;

        for (int i = 0; i < list1.Count; i++)
        {
            double val1 = list1[i] - avg1;
            double val2 = list2[i] - avg2;

            numerator += val1 * val2;
            denom1 += val1 * val1;
            denom2 += val2 * val2;
        }

        return numerator / (Math.Sqrt(denom1) * Math.Sqrt(denom2));
    }
}

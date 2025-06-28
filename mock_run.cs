
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> list1 = new List<double> { 1, 2, 3, 4, 5 };
        List<double> list2 = new List<double> { 2, 3, 4, 5, 6 };

        double correlationCoefficient = CalculateCorrelationCoefficient(list1, list2);

        Console.WriteLine("Correlation Coefficient: " + correlationCoefficient);
    }

    static double CalculateCorrelationCoefficient(List<double> list1, List<double> list2)
    {
        double mean1 = list1.Average();
        double mean2 = list2.Average();

        double sum = 0;
        double sum1 = 0;
        double sum2 = 0;

        for (int i = 0; i < list1.Count; i++)
        {
            double diff1 = list1[i] - mean1;
            double diff2 = list2[i] - mean2;

            sum += diff1 * diff2;
            sum1 += diff1 * diff1;
            sum2 += diff2 * diff2;
        }

        return sum / Math.Sqrt(sum1 * sum2);
    }
}

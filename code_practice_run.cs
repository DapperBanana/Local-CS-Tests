

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> list1 = new List<double> { 1, 2, 3, 4, 5 };
        List<double> list2 = new List<double> { 6, 7, 8, 9, 10 };

        double correlation = CalculateCorrelation(list1, list2);

        Console.WriteLine($"Correlation coefficient between list1 and list2: {correlation}");
    }

    static double CalculateCorrelation(List<double> list1, List<double> list2)
    {
        double sumProduct = 0;
        double sumSquare1 = 0;
        double sumSquare2 = 0;

        double mean1 = list1.Average();
        double mean2 = list2.Average();

        for (int i = 0; i < list1.Count; i++)
        {
            sumProduct += (list1[i] - mean1) * (list2[i] - mean2);
            sumSquare1 += Math.Pow(list1[i] - mean1, 2);
            sumSquare2 += Math.Pow(list2[i] - mean2, 2);
        }

        double correlation = sumProduct / (Math.Sqrt(sumSquare1) * Math.Sqrt(sumSquare2));

        return correlation;
    }
}



using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> list1 = new List<double> { 1, 2, 3, 4, 5 };
        List<double> list2 = new List<double> { 2, 4, 6, 8, 10 };

        double correlationCoefficient = CalculateCorrelationCoefficient(list1, list2);
        
        Console.WriteLine("Correlation Coefficient: " + correlationCoefficient);
    }

    static double CalculateCorrelationCoefficient(List<double> list1, List<double> list2)
    {
        if (list1.Count != list2.Count)
        {
            throw new ArgumentException("Lists must have the same length");
        }

        double sumList1 = list1.Sum();
        double sumList2 = list2.Sum();

        double sumList1Squared = list1.Sum(x => x * x);
        double sumList2Squared = list2.Sum(x => x * x);

        double sumProduct = list1.Zip(list2, (x, y) => x * y).Sum();

        int n = list1.Count;

        double correlationCoefficient = (n * sumProduct - sumList1 * sumList2) /
                                        Math.Sqrt((n * sumList1Squared - Math.Pow(sumList1, 2)) * 
                                                  (n * sumList2Squared - Math.Pow(sumList2, 2)));

        return correlationCoefficient;
  }
}

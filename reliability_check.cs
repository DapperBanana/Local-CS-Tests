
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> numbers = new List<double> { 5.5, 2.1, 7.8, 9.3, 4.2 };

        numbers.Sort();

        double median;
        if (numbers.Count % 2 == 0)
        {
            median = (numbers[numbers.Count / 2] + numbers[numbers.Count / 2 - 1]) / 2;
        }
        else
        {
            median = numbers[numbers.Count / 2];
        }

        Console.WriteLine("Median: {0}", median);
    }
}

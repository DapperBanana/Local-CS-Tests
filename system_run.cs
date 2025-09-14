
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        double median = CalculateMedian(numbers);

        Console.WriteLine("Median: " + median);
    }

    static double CalculateMedian(List<int> numbers)
    {
        numbers.Sort();

        int count = numbers.Count;
        int mid = count / 2;

        if (count % 2 == 0)
        {
            return (numbers[mid - 1] + numbers[mid]) / 2.0;
        }
        else
        {
            return numbers[mid];
        }
    }
}

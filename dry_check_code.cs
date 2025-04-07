
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> numbers = new List<double>{ 12, 36, 45, 71, 23, 56, 8 };

        numbers.Sort();

        double median = CalculateMedian(numbers);

        Console.WriteLine("The median of the list of numbers is: " + median);
    }

    static double CalculateMedian(List<double> numbers)
    {
        int count = numbers.Count;
        if (count % 2 == 0)
        {
            return (numbers[count / 2] + numbers[(count / 2) - 1]) / 2.0;
        }
        else
        {
            return numbers[count / 2];
        }
    }
}

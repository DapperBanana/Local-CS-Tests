
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> numbers = new List<double> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        double median = FindMedian(numbers);

        Console.WriteLine("The median of the list is: " + median);
    }

    static double FindMedian(List<double> numbers)
    {
        numbers.Sort();

        int count = numbers.Count;
        if (count % 2 == 0)
        {
            return (numbers[(count / 2) - 1] + numbers[count / 2]) / 2;
        }
        else
        {
            return numbers[count / 2];
        }
    }
}


using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 6, 8, 12, 15, 18 };
        double median = CalculateMedian(numbers);
        Console.WriteLine("Median: " + median);
    }

    static double CalculateMedian(int[] numbers)
    {
        Array.Sort(numbers);

        int size = numbers.Length;
        
        if (size % 2 == 0)
        {
            int midIndex1 = size / 2 - 1;
            int midIndex2 = size / 2;
            return (numbers[midIndex1] + numbers[midIndex2]) / 2.0;
        }
        else
        {
            int midIndex = size / 2;
            return numbers[midIndex];
        }
    }
}

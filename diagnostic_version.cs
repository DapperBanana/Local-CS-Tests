
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 15, 20, 35, 40, 56 };
        Array.Sort(numbers);

        double median;
        int length = numbers.Length;

        if (length % 2 == 0)
        {
            median = (numbers[length / 2 - 1] + numbers[length / 2]) / 2.0;
        }
        else
        {
            median = numbers[length / 2];
        }

        Console.WriteLine("Median: " + median);
    }
}

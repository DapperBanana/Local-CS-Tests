
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Input list of numbers
        int[] numbers = { 9, 2, 5, 7, 1, 4, 3 };

        // Sort the numbers
        Array.Sort(numbers);

        // Find the median
        double median;
        int n = numbers.Length;
        if (n % 2 == 0)
        {
            median = (numbers[n / 2 - 1] + numbers[n / 2]) / 2.0;
        }
        else
        {
            median = numbers[n / 2];
        }

        // Print the median
        Console.WriteLine("Median: " + median);
    }
}

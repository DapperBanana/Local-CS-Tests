
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Input list of numbers
        int[] numbers = { 5, 2, 8, 3, 1, 10, 6, 4, 7, 9 };

        // Sort the numbers array
        Array.Sort(numbers);

        // Get the length of the array
        int length = numbers.Length;

        // Find the median
        double median;
        if (length % 2 == 0)
        {
            median = (numbers[length / 2 - 1] + numbers[length / 2]) / 2.0;
        }
        else
        {
            median = numbers[length / 2];
        }

        // Output the median
        Console.WriteLine("Median: " + median);
    }
}

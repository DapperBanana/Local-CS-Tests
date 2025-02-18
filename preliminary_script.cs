
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Input list of numbers
        int[] numbers = { 7, 4, 2, 5, 9, 1, 6 };

        // Sort the numbers
        Array.Sort(numbers);

        // Calculate the median
        double median;
        if (numbers.Length % 2 == 0)
        {
            // If the list has even number of elements, average the middle two
            int mid1 = numbers.Length / 2 - 1;
            int mid2 = numbers.Length / 2;
            median = (numbers[mid1] + numbers[mid2]) / 2.0;
        }
        else
        {
            // If the list has odd number of elements, take the middle element
            int mid = numbers.Length / 2;
            median = numbers[mid];
        }

        // Output the median
        Console.WriteLine("Median is: " + median);
    }
}

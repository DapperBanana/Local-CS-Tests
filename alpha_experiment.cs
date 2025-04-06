
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // input list of numbers
        double[] numbers = { 7, 3, 1, 5, 9, 2 };

        // sort the array
        Array.Sort(numbers);

        // calculate the median
        double median;
        int mid = numbers.Length / 2;
        if (numbers.Length % 2 == 0)
        {
            median = (numbers[mid - 1] + numbers[mid]) / 2.0;
        }
        else
        {
            median = numbers[mid];
        }

        Console.WriteLine("Median of the list of numbers is: " + median);
    }
}

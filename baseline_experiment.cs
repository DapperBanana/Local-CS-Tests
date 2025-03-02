
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Input list of numbers
        int[] numbers = { 2, 6, 8, 12, 15 };

        // Sort the array
        Array.Sort(numbers);

        double median;
        if (numbers.Length % 2 == 0)
        {
            // If the length of the array is even
            median = (numbers[numbers.Length / 2 - 1] + numbers[numbers.Length / 2]) / 2.0;
        }
        else
        {
            // If the length of the array is odd
            median = numbers[numbers.Length / 2];
        }

        Console.WriteLine("The median of the list of numbers is: " + median);
    }
}

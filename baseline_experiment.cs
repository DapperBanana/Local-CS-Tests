
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Input list of numbers
        List<double> numbers = new List<double> { 10.5, 3.7, 5.2, 7.8, 9.1, 4.6, 8.3 };

        // Sort the numbers
        numbers.Sort();

        // Calculate median
        double median;
        if (numbers.Count % 2 == 0)
        {
            // If the number of elements is even, average the middle two numbers
            int middleIndex = numbers.Count / 2;
            median = (numbers[middleIndex - 1] + numbers[middleIndex]) / 2;
        }
        else
        {
            // If the number of elements is odd, take the middle number
            median = numbers[numbers.Count / 2];
        }

        Console.WriteLine("The median of the list of numbers is: " + median);
    }
}

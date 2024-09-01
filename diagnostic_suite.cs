
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 8, 2, 5, 7, 3, 9, 1, 4, 6 };
        numbers.Sort();

        double median;

        if (numbers.Count % 2 == 0)
        {
            // If the list has an even number of elements, average the middle two
            median = (numbers[numbers.Count / 2 - 1] + numbers[numbers.Count / 2]) / 2.0;
        }
        else
        {
            // If the list has an odd number of elements, take the middle element
            median = numbers[numbers.Count / 2];
        }

        Console.WriteLine($"The median of the list is: {median}");
    }
}

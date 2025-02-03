
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 2, 8, 1, 4, 7, 6, 3 };

        numbers.Sort();

        double median;
        int middle = numbers.Count / 2;

        if (numbers.Count % 2 == 0)
        {
            median = (numbers[middle - 1] + numbers[middle]) / 2.0;
        }
        else
        {
            median = numbers[middle];
        }

        Console.WriteLine("The median of the list is: " + median);
    }
}

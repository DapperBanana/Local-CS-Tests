
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 3, 7, 2, 8, 4 };

        numbers.Sort();

        double median;
        int middleIndex = numbers.Count / 2;

        if (numbers.Count % 2 == 0)
        {
            median = (numbers[middleIndex - 1] + numbers[middleIndex]) / 2.0;
        }
        else
        {
            median = numbers[middleIndex];
        }

        Console.WriteLine("The median of the list of numbers is: " + median);
    }
}

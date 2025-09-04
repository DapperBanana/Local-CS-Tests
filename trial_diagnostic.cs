
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 2, 8, 3, 6, 1, 7, 4 };

        numbers.Sort();

        double median;

        if (numbers.Count % 2 == 0)
        {
            median = (numbers[numbers.Count / 2 - 1] + numbers[numbers.Count / 2]) / 2.0;
        }
        else
        {
            median = numbers[numbers.Count / 2];
        }

        Console.WriteLine("The median of the numbers is: " + median);
    }
}

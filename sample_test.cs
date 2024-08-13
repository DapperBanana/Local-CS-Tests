
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 2, 8, 10, 1, 9, 4, 7, 3, 6 };

        numbers.Sort();

        int n = numbers.Count;

        double median;

        if (n % 2 == 0)
        {
            int middleIndex1 = n / 2 - 1;
            int middleIndex2 = n / 2;
            median = (numbers[middleIndex1] + numbers[middleIndex2]) / 2.0;
        }
        else
        {
            int middleIndex = n / 2;
            median = numbers[middleIndex];
        }

        Console.WriteLine("The median of the numbers is: " + median);
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 8, 2, 10, 15, 7, 3, 12, 6, 9 };
        
        double median = CalculateMedian(numbers);

        Console.WriteLine("The median of the list of numbers is: " + median);
    }

    static double CalculateMedian(List<int> numbers)
    {
        numbers.Sort();

        if (numbers.Count % 2 == 0)
        {
            int middleIndex1 = numbers.Count / 2 - 1;
            int middleIndex2 = numbers.Count / 2;
            return (double)(numbers[middleIndex1] + numbers[middleIndex2]) / 2;
        }
        else
        {
            int middleIndex = numbers.Count / 2;
            return numbers[middleIndex];
        }
    }
}

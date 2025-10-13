
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 10, 15, 20, 25 };
    
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

        Console.WriteLine("Median: " + median);
    }
}

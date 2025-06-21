
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 5, 7, 3, 8, 12, 15, 6 };

        numbers.Sort();
        int median;

        if (numbers.Count % 2 == 0)
        {
            median = (numbers[numbers.Count / 2] + numbers[numbers.Count / 2 - 1]) / 2;
        }
        else
        {
            median = numbers[numbers.Count / 2];
        }

        Console.WriteLine($"The median of the list of numbers is: {median}");
    }
}

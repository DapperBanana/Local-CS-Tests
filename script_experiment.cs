
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        
        // Get input numbers
        Console.WriteLine("Enter a list of numbers separated by spaces:");
        string input = Console.ReadLine();
        string[] numberStrings = input.Split(' ');

        foreach (string numStr in numberStrings)
        {
            int num;
            if (int.TryParse(numStr, out num))
            {
                numbers.Add(num);
            }
        }

        // Sort the list of numbers
        numbers.Sort();

        // Find the median
        double median;
        if (numbers.Count % 2 == 0)
        {
            int mid1 = numbers.Count / 2 - 1;
            int mid2 = numbers.Count / 2;
            median = (numbers[mid1] + numbers[mid2]) / 2.0;
        }
        else
        {
            int mid = numbers.Count / 2;
            median = numbers[mid];
        }

        Console.WriteLine("The median of the list of numbers is: " + median);
    }
}

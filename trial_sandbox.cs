
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers separated by spaces:");

        string input = Console.ReadLine();
        string[] numberStrings = input.Split(' ');

        foreach (string numStr in numberStrings)
        {
            numbers.Add(int.Parse(numStr));
        }

        numbers.Sort();

        double median;

        if (numbers.Count % 2 == 0)
        {
            int middleIndex1 = numbers.Count / 2 - 1;
            int middleIndex2 = numbers.Count / 2;
            median = (numbers[middleIndex1] + numbers[middleIndex2]) / 2.0;
        }
        else
        {
            int middleIndex = numbers.Count / 2;
            median = numbers[middleIndex];
        }

        Console.WriteLine("The median of the numbers is: " + median);
    }
}

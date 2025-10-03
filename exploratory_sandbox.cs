
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

        foreach (var numberString in numberStrings)
        {
            int number;
            if (int.TryParse(numberString, out number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine($"Invalid number: {numberString}");
            }
        }

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

        Console.WriteLine($"The median of the numbers is: {median}");
    }
}

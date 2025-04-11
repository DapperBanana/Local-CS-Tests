
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, int> numbers = new Dictionary<int, int>()
        {
            {1, 10},
            {2, 20},
            {3, 5},
            {4, 15}
        };

        int max = int.MinValue; // Initialize max to the smallest possible integer value
        int min = int.MaxValue; // Initialize min to the largest possible integer value

        foreach (var keyValue in numbers)
        {
            if (keyValue.Value > max)
            {
                max = keyValue.Value;
            }

            if (keyValue.Value < min)
            {
                min = keyValue.Value;
            }
        }

        Console.WriteLine("Maximum value in dictionary: " + max);
        Console.WriteLine("Minimum value in dictionary: " + min);
    }
}

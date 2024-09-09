
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List of integers to be sorted
        List<int> numbers = new List<int> { 5, 2, 8, 1, 3 };

        // Sort the list in ascending order
        numbers.Sort();

        // Display the sorted list
        Console.WriteLine("Sorted List:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

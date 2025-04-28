
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 2, 8, 1, 3 };

        Console.WriteLine("Before sorting:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Sort the list in ascending order
        numbers.Sort();

        Console.WriteLine("After sorting:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

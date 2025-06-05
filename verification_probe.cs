
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 3, 5, 1, 7, 3, 9, 5, 11, 13, 9 };

        var uniqueNumbers = numbers.Distinct().ToList();

        Console.WriteLine("Original list:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nList with duplicates removed while preserving order:");
        foreach (int num in uniqueNumbers)
        {
            Console.Write(num + " ");
        }
    }
}


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine("Original list:");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] = numbers[i] * numbers[i];
        }

        Console.WriteLine("\nList with square of each element:");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}

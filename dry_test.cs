
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 2, 3, 5, 7, 11 };

        Console.WriteLine("Original list:");

        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\n\nSquared list:");

        foreach (int num in numbers)
        {
            Console.Write(num * num + " ");
        }

        Console.ReadLine();
    }
}

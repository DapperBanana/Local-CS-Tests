
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 2, 8, 1, 3, 7, 4 };

        numbers.Sort();

        Console.WriteLine("Sorted numbers:");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.ReadLine();
    }
}

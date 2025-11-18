
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 2, 8, 3, 1, 7, 4, 6 };

        numbers.Sort();

        Console.WriteLine("Sorted numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

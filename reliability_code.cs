
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 2, 9, 1, 7, 3 };

        numbers.Sort();

        Console.WriteLine("Sorted numbers:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}

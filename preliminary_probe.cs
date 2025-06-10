
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 3, 9, 1, 7, 2, 8 };

        numbers.Sort();

        Console.WriteLine("Sorted numbers:");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.ReadLine();
    }
}

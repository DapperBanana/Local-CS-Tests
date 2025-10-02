
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 4, 5, 6, 6, 7, 8, 9, 9 };

        List<int> uniqueNumbers = new List<int>();
        HashSet<int> seen = new HashSet<int>();

        foreach (var number in numbers)
        {
            if (seen.Add(number))
            {
                uniqueNumbers.Add(number);
            }
        }

        Console.WriteLine("Original List:");
        PrintList(numbers);

        Console.WriteLine("\nList with Duplicates Removed:");
        PrintList(uniqueNumbers);
    }

    static void PrintList(List<int> list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
    }
}

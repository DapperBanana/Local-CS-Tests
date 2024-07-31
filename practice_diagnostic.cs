
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 2, 5, 6, 1, 7, 8, 9 };

        List<int> uniqueNumbers = RemoveDuplicates(numbers);

        Console.WriteLine("Original List:");
        numbers.ForEach(Console.WriteLine);

        Console.WriteLine("\nList with Duplicates Removed:");
        uniqueNumbers.ForEach(Console.WriteLine);
    }

    static List<T> RemoveDuplicates<T>(List<T> list)
    {
        HashSet<T> seen = new HashSet<T>();
        List<T> uniqueList = new List<T>();

        foreach (T item in list)
        {
            if (seen.Add(item))
            {
                uniqueList.Add(item);
            }
        }

        return uniqueList;
    }
}

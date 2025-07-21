
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 2, 5, 6, 3, 7, 8, 9, 1 };
        List<int> uniqueNumbers = RemoveDuplicates(numbers);

        Console.WriteLine("Original List:");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\n\nList with Duplicates Removed:");
        foreach (var number in uniqueNumbers)
        {
            Console.Write(number + " ");
        }
    }

    static List<T> RemoveDuplicates<T>(List<T> list)
    {
        List<T> uniqueList = new List<T>();
        HashSet<T> set = new HashSet<T>();

        foreach (T item in list)
        {
            if (set.Add(item))
            {
                uniqueList.Add(item);
            }
        }

        return uniqueList;
    }
}

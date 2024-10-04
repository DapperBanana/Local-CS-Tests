
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 3, 5, 2, 3, 4, 5, 1, 4 };
        List<int> uniqueNumbers = RemoveDuplicates(numbers);

        Console.WriteLine("Original list:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nList with duplicates removed:");
        foreach (int num in uniqueNumbers)
        {
            Console.Write(num + " ");
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

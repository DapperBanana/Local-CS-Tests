
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = new List<int> { 1, 3, 2, 4, 1, 3, 5, 2, 6, 7, 8, 5 };
        List<int> result = RemoveDuplicates(list);

        Console.WriteLine("Original list:");
        foreach (int num in list)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nList after removing duplicates:");
        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }

    static List<T> RemoveDuplicates<T>(List<T> list)
    {
        List<T> result = new List<T>();
        HashSet<T> set = new HashSet<T>();

        foreach (T item in list)
        {
            if (set.Add(item))
            {
                result.Add(item);
            }
        }

        return result;
    }
}

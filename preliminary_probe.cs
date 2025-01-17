
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> myList = new List<int> { 1, 2, 3, 4, 2, 1, 5, 6, 7, 8, 7, 9 };

        List<int> result = RemoveDuplicates(myList);

        Console.WriteLine("Original list:");
        foreach (var item in myList)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\nList with duplicates removed:");
        foreach (var item in result)
        {
            Console.Write(item + " ");
        }
    }

    static List<T> RemoveDuplicates<T>(List<T> list)
    {
        HashSet<T> seen = new HashSet<T>();
        List<T> result = new List<T>();

        foreach (var item in list)
        {
            if (!seen.Contains(item))
            {
                seen.Add(item);
                result.Add(item);
            }
        }

        return result;
    }
}

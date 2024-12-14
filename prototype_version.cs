
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> listWithDuplicates = new List<int> { 1, 2, 3, 4, 2, 5, 6, 3, 7 };

        List<int> listWithoutDuplicates = RemoveDuplicates(listWithDuplicates);

        Console.WriteLine("List with duplicates:");
        foreach (int num in listWithDuplicates)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nList without duplicates:");
        foreach (int num in listWithoutDuplicates)
        {
            Console.Write(num + " ");
        }
    }

    static List<T> RemoveDuplicates<T>(List<T> list)
    {
        HashSet<T> seen = new HashSet<T>();
        List<T> resultList = new List<T>();

        foreach (T item in list)
        {
            if (seen.Add(item))
            {
                resultList.Add(item);
            }
        }

        return resultList;
    }
}


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 2, 3, 5, 6, 4 };

        List<int> uniqueNumbers = RemoveDuplicates(numbers);

        Console.WriteLine("Original list:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nUnique list:");
        foreach (int num in uniqueNumbers)
        {
            Console.Write(num + " ");
        }
    }

    static List<T> RemoveDuplicates<T>(List<T> inputList)
    {
        List<T> uniqueList = new List<T>();
        HashSet<T> seen = new HashSet<T>();

        foreach (T item in inputList)
        {
            if (seen.Add(item))
            {
                uniqueList.Add(item);
            }
        }

        return uniqueList;
    }
}

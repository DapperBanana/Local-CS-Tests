
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 2, 5, 3, 6, 7, 8, 9, 1 };

        List<int> result = RemoveDuplicates(numbers);

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

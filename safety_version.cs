
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 3, 5, 2, 7, 3, 5, 1, 8, 9, 2 };

        List<int> distinctNumbers = RemoveDuplicates(numbers);

        foreach (int number in distinctNumbers)
        {
            Console.Write(number + " ");
        }
    }

    static List<T> RemoveDuplicates<T>(List<T> list)
    {
        HashSet<T> seen = new HashSet<T>();
        List<T> result = new List<T>();

        foreach (T item in list)
        {
            if (seen.Add(item))
            {
                result.Add(item);
            }
        }

        return result;
    }
}

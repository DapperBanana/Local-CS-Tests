
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 3, 5, 2, 3, 4, 2, 5 };

        List<int> result = RemoveDuplicates(numbers);

        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }

    static List<T> RemoveDuplicates<T>(List<T> input)
    {
        HashSet<T> seen = new HashSet<T>();
        List<T> output = new List<T>();

        foreach (T item in input)
        {
            if (!seen.Contains(item))
            {
                seen.Add(item);
                output.Add(item);
            }
        }

        return output;
    }
}

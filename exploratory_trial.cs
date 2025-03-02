
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 3, 5, 6, 1 };

        List<int> uniqueNumbers = RemoveDuplicates(numbers);

        foreach (int number in uniqueNumbers)
        {
            Console.WriteLine(number);
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

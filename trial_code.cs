
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 3, 4, 4, 5, 5 };
        List<int> uniqueNumbers = RemoveDuplicates(numbers);

        foreach (var number in uniqueNumbers)
        {
            Console.Write(number + " ");
        }
    }

    static List<T> RemoveDuplicates<T>(List<T> list)
    {
        List<T> uniqueList = new List<T>();
        HashSet<T> set = new HashSet<T>();

        foreach (var item in list)
        {
            if (set.Add(item))
            {
                uniqueList.Add(item);
            }
        }

        return uniqueList;
    }
}

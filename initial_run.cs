
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

        List<int> commonElements = new List<int>();

        foreach (var item1 in list1)
        {
            foreach (var item2 in list2)
            {
                if (item1 == item2)
                {
                    commonElements.Add(item1);
                    break;
                }
            }
        }

        Console.WriteLine("Common elements between the two lists are: ");
        foreach (var element in commonElements)
        {
            Console.WriteLine(element);
        }
    }
}

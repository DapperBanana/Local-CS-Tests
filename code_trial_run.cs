
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

        List<int> commonElements = new List<int>();

        foreach (int num in list1)
        {
            if (list2.Contains(num))
            {
                commonElements.Add(num);
            }
        }

        Console.WriteLine("Common elements between the two lists are:");
        foreach (int num in commonElements)
        {
            Console.Write(num + " ");
        }
    }
}

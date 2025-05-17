
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

        List<int> commonElements = new List<int>();

        foreach (int num1 in list1)
        {
            foreach (int num2 in list2)
            {
                if (num1 == num2)
                {
                    commonElements.Add(num1);
                    break;
                }
            }
        }

        Console.WriteLine("Common elements between the two lists:");
        foreach (int num in commonElements)
        {
            Console.WriteLine(num);
        }
    }
}

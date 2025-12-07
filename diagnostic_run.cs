using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 3, 5, 7, 2, 8, 8, 4 };
        int? secondLargest = FindSecondLargest(numbers);

        if (secondLargest.HasValue)
            Console.WriteLine($"The second largest element is: {secondLargest.Value}");
        else
            Console.WriteLine("The list does not have a second largest element.");
    }

    static int? FindSecondLargest(List<int> list)
    {
        if (list == null || list.Count < 2)
            return null;

        int? first = null, second = null;

        foreach (int num in list)
        {
            if (first == null || num > first)
            {
                second = first;
                first = num;
            }
            else if ((second == null || num > second) && num != first)
            {
                second = num;
            }
        }

        return second;
    }
}
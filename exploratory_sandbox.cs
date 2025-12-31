using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 3, 9, 1, 7, 9, 2 };

        int? secondLargest = FindSecondLargest(numbers);
        if (secondLargest.HasValue)
        {
            Console.WriteLine($"The second largest element is: {secondLargest.Value}");
        }
        else
        {
            Console.WriteLine("The list does not have a second largest element.");
        }
    }

    static int? FindSecondLargest(List<int> list)
    {
        if (list == null || list.Count < 2)
            return null;

        int max = int.MinValue;
        int secondMax = int.MinValue;

        foreach (int num in list)
        {
            if (num > max)
            {
                secondMax = max;
                max = num;
            }
            else if (num > secondMax && num != max)
            {
                secondMax = num;
            }
        }

        return secondMax == int.MinValue ? (int?)null : secondMax;
    }
}
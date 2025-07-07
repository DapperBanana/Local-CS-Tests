
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 10, 3, 8, 12, 6, 15 };

        int secondLargest = FindSecondLargest(numbers);

        Console.WriteLine("The second largest element in the list is: " + secondLargest);
    }

    static int FindSecondLargest(List<int> numbers)
    {
        int max = Int32.MinValue;
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        int secondMax = Int32.MinValue;
        foreach (int num in numbers)
        {
            if (num != max && num > secondMax)
            {
                secondMax = num;
            }
        }

        return secondMax;
    }
}

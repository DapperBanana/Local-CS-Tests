
using System;
using System.Collections.Generic;

class Program
{
    static int FindSecondLargest(List<int> list)
    {
        int firstLargest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int num in list)
        {
            if (num > firstLargest)
            {
                secondLargest = firstLargest;
                firstLargest = num;
            }
            else if (num > secondLargest && num != firstLargest)
            {
                secondLargest = num;
            }
        }

        return secondLargest;
    }

    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 10, 5, 20, 15, 30, 25 };

        int secondLargest = FindSecondLargest(numbers);

        Console.WriteLine("The second largest element in the list is: " + secondLargest);
    }
}

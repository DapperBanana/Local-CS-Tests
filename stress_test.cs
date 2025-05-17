
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numberList = new List<int> { 10, 30, 15, 50, 25, 40 };

        int largestNumber = FindLargestElement(numberList);

        Console.WriteLine("The largest element in the list is: " + largestNumber);
    }

    static int FindLargestElement(List<int> list)
    {
        int largestNumber = int.MinValue;

        foreach (int num in list)
        {
            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }

        return largestNumber;
    }
}

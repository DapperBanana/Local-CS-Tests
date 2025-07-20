
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 5, 20, 15, 30 };

        int largestNumber = FindLargestElement(numbers);

        Console.WriteLine("The largest element in the list is: " + largestNumber);
    }

    static int FindLargestElement(List<int> numbers)
    {
        int largest = numbers[0];

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

        return largest;
    }
}

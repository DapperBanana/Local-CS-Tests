
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 30, 50, 20, 40 };

        int largest = FindLargestElement(numbers);

        Console.WriteLine($"The largest element in the list is: {largest}");
    }

    static int FindLargestElement(List<int> numbers)
    {
        int largest = int.MinValue;

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        return largest;
    }
}

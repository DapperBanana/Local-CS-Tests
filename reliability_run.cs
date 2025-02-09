
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 5, 8, 12, 3, 15 };

        int largestNumber = FindLargestElement(numbers);

        Console.WriteLine("The largest number in the list is: " + largestNumber);
    }

    static int FindLargestElement(List<int> numbers)
    {
        int largest = numbers[0];

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

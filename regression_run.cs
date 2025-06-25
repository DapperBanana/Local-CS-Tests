
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 5, 15, 30 };

        int secondLargest = FindSecondLargestElement(numbers);

        Console.WriteLine("Second largest element in the list is: " + secondLargest);
    }

    static int FindSecondLargestElement(List<int> numbers)
    {
        if (numbers.Count < 2)
        {
            throw new ArgumentException("List must have at least 2 elements");
        }

        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (num > secondLargest && num != largest)
            {
                secondLargest = num;
            }
        }

        return secondLargest;
    }
}

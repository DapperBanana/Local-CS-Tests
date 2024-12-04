
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 40, 30, 50, 60 };

        int largest = int.MinValue;
        int secondLargest = int.MinValue;

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

        Console.WriteLine("Second largest element in the list: " + secondLargest);
    }
}

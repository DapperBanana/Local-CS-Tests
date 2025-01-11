
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 10, 15, 20, 25 };

        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                secondLargest = largest;
                largest = number;
            }
            else if (number > secondLargest && number != largest)
            {
                secondLargest = number;
            }
        }

        Console.WriteLine("List of numbers: " + string.Join(", ", numbers));
        Console.WriteLine("Second largest element: " + secondLargest);
    }
}

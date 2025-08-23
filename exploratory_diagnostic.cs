
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 25, 5, 50, 15, 30 };

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

        Console.WriteLine("The second largest element in the list is: " + secondLargest);
    }
}

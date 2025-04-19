
using System;
using System.Collections.Generic;

class Program
{
    static int FindSecondLargest(List<int> list)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int num in list)
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

    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        int secondLargest = FindSecondLargest(numbers);

        Console.WriteLine("The second largest element in the list is: " + secondLargest);
    }
}

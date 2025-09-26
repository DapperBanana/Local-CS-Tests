
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 5, 30, 15 };

        int largest = FindLargestElement(numbers);

        Console.WriteLine("The largest element in the list is: " + largest);
    }

    static int FindLargestElement(List<int> list)
    {
        int largest = list[0];
        foreach (int num in list)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

        return largest;
    }
}

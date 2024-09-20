
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        
        numbers.Sort(); // Sort the list in ascending order

        if (numbers.Count < 2)
        {
            Console.WriteLine("There is no second largest element in the list.");
        }
        else
        {
            int secondLargest = numbers[numbers.Count - 2];
            Console.WriteLine($"The second largest element in the list is: {secondLargest}");
        }
    }
}

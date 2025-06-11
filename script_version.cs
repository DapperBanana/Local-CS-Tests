
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of integers
        List<int> numbers = new List<int>() { 55, 29, 87, 44, 12, 97, 63 };

        // Initialize the largest number as the first element of the list
        int largestNumber = numbers[0];

        // Loop through the list and update the largest number if a bigger number is found
        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }

        Console.WriteLine("The largest number in the list is: " + largestNumber);
    }
}


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 15, 5, 20, 8, 25 };

        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

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

        if (secondLargest != Int32.MinValue)
        {
            Console.WriteLine("The second largest element in the list is: " + secondLargest);
        }
        else
        {
            Console.WriteLine("There is no second largest element in the list.");
        }
    }
}

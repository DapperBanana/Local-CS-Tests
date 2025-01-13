
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 12, 34, 56, 78, 90, 23, 45 };
        
        int largest = int.MinValue;
        int secondLargest = int.MinValue;
        
        foreach(int num in numbers)
        {
            if(num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if(num > secondLargest && num != largest)
            {
                secondLargest = num;
            }
        }
        
        Console.WriteLine("The second largest element in the list is: " + secondLargest);
    }
}

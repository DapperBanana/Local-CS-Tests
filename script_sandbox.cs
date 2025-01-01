
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 3, 7, 1, 5, 9, 2 };

        double median = GetMedian(numbers);

        Console.WriteLine("The median of the numbers is: " + median);
    }

    static double GetMedian(List<int> numbers)
    {
        numbers.Sort();
        
        int count = numbers.Count;
        
        if (count % 2 == 0)
        {
            int middleIndex1 = count / 2;
            int middleIndex2 = middleIndex1 - 1;
            
            return (numbers[middleIndex1] + numbers[middleIndex2]) / 2.0;
        }
        else
        {
            return numbers[count / 2];
        }
    }
}

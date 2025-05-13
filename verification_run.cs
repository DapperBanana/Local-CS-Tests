
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        
        int max = int.MinValue;
        int secondMax = int.MinValue;
        
        foreach (int num in numbers)
        {
            if (num > max)
            {
                secondMax = max;
                max = num;
            }
            else if (num > secondMax && num != max)
            {
                secondMax = num;
            }
        }
        
        if (secondMax == int.MinValue)
        {
            Console.WriteLine("There is no second largest element.");
        }
        else
        {
            Console.WriteLine("The second largest element is: " + secondMax);
        }
    }
}


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 25, 8, 17, 33, 15 };

        int firstMax = int.MinValue;
        int secondMax = int.MinValue;

        foreach (int num in numbers)
        {
            if (num > firstMax)
            {
                secondMax = firstMax;
                firstMax = num;
            }
            else if (num > secondMax && num != firstMax)
            {
                secondMax = num;
            }
        }

        Console.WriteLine("The second largest element in the list is: " + secondMax);
    }
}

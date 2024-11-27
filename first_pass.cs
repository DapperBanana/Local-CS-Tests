
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 3, 8, 4, 7, 2, 10, 11, 12, 13 };

        int maxLength = 0;
        int currentLength = 1;
        int currentNumber = numbers[0];

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] == currentNumber + 1)
            {
                currentLength++;
            }
            else
            {
                maxLength = Math.Max(maxLength, currentLength);
                currentLength = 1;
            }

            currentNumber = numbers[i];
        }

        maxLength = Math.Max(maxLength, currentLength);

        Console.WriteLine("The longest consecutive sequence length is: " + maxLength);
    }
}


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 4, 5, 6, 7, 9, 10, 11, 12, 13 };

        int maxLength = 0;
        int currentLength = 1;
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i - 1] + 1)
            {
                currentLength++;

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    endIndex = i;
                    startIndex = endIndex - maxLength + 1;
                }
            }
            else
            {
                currentLength = 1;
            }
        }

        Console.WriteLine("Longest consecutive sequence:");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}

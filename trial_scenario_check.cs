
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 3, 8, 1, 6, 4, 2, 7 };

        List<int> list = new List<int>(numbers);
        list.Sort();

        int maxLength = 1;
        int currentLength = 1;
        int start = list[0];

        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] == list[i - 1] + 1)
            {
                currentLength++;
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    start = list[i - currentLength];
                }
                currentLength = 1;
            }
        }

        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            start = list[list.Count - currentLength];
        }

        Console.WriteLine($"Longest consecutive sequence: ");
        for (int i = start; i < start + maxLength; i++)
        {
            Console.Write(i + " ");
        }
    }
}

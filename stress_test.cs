
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60, 80 };
        int n = arr.Length;
        int[] lis = new int[n];

        for (int i = 0; i < n; i++)
        {
            lis[i] = 1;
            for (int j = 0; j < i; j++)
            {
                if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                {
                    lis[i] = lis[j] + 1;
                }
            }
        }

        int maxLength = 0;
        for (int i = 0; i < n; i++)
        {
            if (lis[i] > maxLength)
            {
                maxLength = lis[i];
            }
        }

        Console.WriteLine("Length of longest increasing subsequence: " + maxLength);
    }
}

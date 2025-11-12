
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 2, 9, 1, 6 };

        Console.WriteLine("Before sorting:");
        PrintArray(numbers);

        Array.Sort(numbers);

        Console.WriteLine("\nAfter sorting:");
        PrintArray(numbers);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 2, 8, 1, 3, 6, 4, 7 };
        
        // Sort the numbers array in ascending order
        Array.Sort(numbers);

        // Print the sorted numbers
        Console.WriteLine("Sorted numbers:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

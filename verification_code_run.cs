
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        
        Console.WriteLine("Original List:");
        foreach(int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        List<int> squares = numbers.Select(x => x * x).ToList();

        Console.WriteLine("Squared List:");
        foreach(int num in squares)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

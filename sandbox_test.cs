
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        
        Console.WriteLine("Original List:");
        foreach(var num in numbers)
        {
            Console.Write(num + " ");
        }
        
        Console.WriteLine("\n\nSquares of each element:");
        foreach(var num in numbers)
        {
            int square = num * num;
            Console.Write(square + " ");
        }
    }
}

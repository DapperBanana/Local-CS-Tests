
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 2, 3, 5, 7, 10 };
        
        Console.WriteLine("Original List:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        
        List<int> squares = new List<int>();
        
        foreach (int num in numbers)
        {
            squares.Add(num * num);
        }
        
        Console.WriteLine("Squares of each element:");
        foreach (int square in squares)
        {
            Console.Write(square + " ");
        }
        Console.WriteLine();
    }
}

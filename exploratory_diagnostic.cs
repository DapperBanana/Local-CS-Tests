
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        
        Console.WriteLine("Original List:");
        PrintList(numbers);
        
        List<int> squares = CalculateSquares(numbers);
        
        Console.WriteLine("\nSquared List:");
        PrintList(squares);
    }

    static List<int> CalculateSquares(List<int> numbers)
    {
        List<int> squares = new List<int>();
        
        foreach(int num in numbers)
        {
            squares.Add(num * num);
        }
        
        return squares;
    }

    static void PrintList(List<int> list)
    {
        foreach(int num in list)
        {
            Console.Write(num + " ");
        }
    }
}


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine("Original list:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        List<int> squares = CalculateSquares(numbers);

        Console.WriteLine("\nSquares of each element:");
        foreach (int square in squares)
        {
            Console.Write(square + " ");
        }
    }

    static List<int> CalculateSquares(List<int> numbers)
    {
        List<int> squares = new List<int>();

        foreach (int num in numbers)
        {
            squares.Add(num * num);
        }

        return squares;
    }
}



using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine("Original List:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        List<int> squares = CalculateSquares(numbers);

        Console.WriteLine("\n\nSquare of each element:");
        foreach (int sqr in squares)
        {
            Console.Write(sqr + " ");
        }

        Console.ReadLine();
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

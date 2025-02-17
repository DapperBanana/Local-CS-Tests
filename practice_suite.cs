
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine("Original list:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        List<int> squares = CalculateSquares(numbers);

        Console.WriteLine("Squared list:");
        foreach (int square in squares)
        {
            Console.Write(square + " ");
        }
        Console.WriteLine();
    }

    static List<int> CalculateSquares(List<int> numbers)
    {
        List<int> squares = new List<int>();

        foreach (int number in numbers)
        {
            squares.Add(number * number);
        }

        return squares;
    }
}

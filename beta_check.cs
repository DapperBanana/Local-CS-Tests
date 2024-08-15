
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 2, 4, 6, 8, 10 };

        Console.WriteLine("Original List:");
        PrintList(numbers);

        List<int> squares = CalculateSquares(numbers);

        Console.WriteLine("\nSquares List:");
        PrintList(squares);
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

    static void PrintList(List<int> list)
    {
        foreach (int item in list)
        {
            Console.Write(item + " ");
        }
    }
}

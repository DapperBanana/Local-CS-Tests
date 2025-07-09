
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

        Console.WriteLine("\n\nCalculating square of each element:");
        List<int> squaredNumbers = CalculateSquare(numbers);

        Console.WriteLine("Squared list:");
        foreach (int num in squaredNumbers)
        {
            Console.Write(num + " ");
        }
    }

    static List<int> CalculateSquare(List<int> numbers)
    {
        List<int> squaredNumbers = new List<int>();

        foreach (int num in numbers)
        {
            int square = num * num;
            squaredNumbers.Add(square);
        }

        return squaredNumbers;
    }
}

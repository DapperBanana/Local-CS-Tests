
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine("Original list:");
        PrintList(numbers);

        Console.WriteLine("\nSquare of each element:");
        List<int> squaredNumbers = SquareListElements(numbers);
        PrintList(squaredNumbers);
    }

    static List<int> SquareListElements(List<int> list)
    {
        List<int> result = new List<int>();

        foreach (int num in list)
        {
            result.Add(num * num);
        }

        return result;
    }

    static void PrintList(List<int> list)
    {
        foreach (int num in list)
        {
            Console.Write(num + " ");
        }
    }
}

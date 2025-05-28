
using System;
using System.Collections.Generic;

class Program
{
    static List<int> CalculateSquare(List<int> numbers)
    {
        List<int> squares = new List<int>();

        foreach (int num in numbers)
        {
            squares.Add(num * num);
        }

        return squares;
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        List<int> squares = CalculateSquare(numbers);

        Console.WriteLine("Original list: " + string.Join(", ", numbers));
        Console.WriteLine("Squares list: " + string.Join(", ", squares));
    }
}

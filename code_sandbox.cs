
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        
        List<int> squares = CalculateSquares(numbers);
        
        foreach(int square in squares)
        {
            Console.WriteLine(square);
        }
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
}

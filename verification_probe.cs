
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        
        List<int> squaredNumbers = CalculateSquare(numbers);

        foreach(int num in squaredNumbers)
        {
            Console.WriteLine(num);
        }
    }

    static List<int> CalculateSquare(List<int> numbers)
    {
        List<int> squaredNumbers = new List<int>();

        foreach(int num in numbers)
        {
            squaredNumbers.Add(num * num);
        }

        return squaredNumbers;
    }
}

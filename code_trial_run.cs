
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        int sum = CalculateSum(numbers);

        Console.WriteLine($"The sum of all elements in the list is: {sum}");
    }

    static int CalculateSum(List<int> numbers)
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum;
    }
}

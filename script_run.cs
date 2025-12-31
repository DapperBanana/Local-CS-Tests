using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Example list of numbers
        List<int> numbers = new List<int> { 12, 15, 20 };

        int lcm = CalculateLCM(numbers);
        Console.WriteLine($"LCM of {string.Join(", ", numbers)} is {lcm}");
    }

    static int CalculateLCM(List<int> numbers)
    {
        if (numbers == null || !numbers.Any())
            return 0;

        int result = numbers[0];
        for (int i = 1; i < numbers.Count; i++)
        {
            result = LCM(result, numbers[i]);
        }
        return result;
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }

    static int LCM(int a, int b)
    {
        return Math.Abs(a * b) / GCD(a, b);
    }
}
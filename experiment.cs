using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Example list of numbers
        List<int> numbers = new List<int> { 12, 15, 20 };

        Console.WriteLine("Numbers: " + string.Join(", ", numbers));
        long lcm = CalculateLCM(numbers);
        Console.WriteLine($"LCM: {lcm}");
    }

    static long CalculateLCM(List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
            return 0;

        long lcm = numbers[0];

        for (int i = 1; i < numbers.Count; i++)
        {
            lcm = LCM(lcm, numbers[i]);
        }

        return lcm;
    }

    static long LCM(long a, int b)
    {
        return Math.Abs(a * b) / GCD(a, b);
    }

    static long GCD(long a, long b)
    {
        while (b != 0)
        {
            long temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
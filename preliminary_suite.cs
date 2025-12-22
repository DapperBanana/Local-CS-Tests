using System;
using System.Collections.Generic;

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
        if (numbers == null || numbers.Count == 0)
            throw new ArgumentException("List of numbers cannot be null or empty.");

        int lcm = numbers[0];

        for (int i = 1; i < numbers.Count; i++)
        {
            lcm = LCM(lcm, numbers[i]);
        }

        return lcm;
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int LCM(int a, int b)
    {
        return (a / GCD(a, b)) * b; // To prevent overflow, divide before multiply
    }
}
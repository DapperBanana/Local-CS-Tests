
using System;

class Program
{
    // Function to calculate GCD of two numbers
    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;
        return GCD(b, a % b);
    }

    // Function to calculate LCM of two numbers
    static int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
    }

    // Function to calculate LCM of a list of numbers
    static int CalculateLCM(int[] numbers)
    {
        int result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            result = LCM(result, numbers[i]);
        }
        return result;
    }

    static void Main()
    {
        int[] numbers = { 4, 6, 8, 10 };

        int lcm = CalculateLCM(numbers);
        Console.WriteLine("LCM of numbers {0} is: {1}", string.Join(", ", numbers), lcm);
    }
}

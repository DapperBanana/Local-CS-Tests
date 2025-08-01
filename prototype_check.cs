
using System;

class Program
{
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

    static long LCM(long a, long b)
    {
        return (a / GCD(a, b)) * b;
    }

    static long LCMOfNumbers(long[] numbers)
    {
        long result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            result = LCM(result, numbers[i]);
        }
        return result;
    }

    static void Main()
    {
        long[] numbers = { 4, 6, 8 };
        Console.WriteLine("LCM of numbers {0} is: {1}", string.Join(", ", numbers), LCMOfNumbers(numbers));
    }
}
